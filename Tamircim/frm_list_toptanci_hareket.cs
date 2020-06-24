using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_list_toptanci_hareket : Form
    {
        private musteri musteri { set; get; }
        private List<tedarik> items;
        public frm_list_toptanci_hareket(musteri musteri)
        {
            this.musteri = musteri;
            this.InitializeComponent();
        }

        private void frm_list_toptanci_hareket_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            this.txt_toptanci_name.Text = this.musteri.ad;
            this.txt_toptanci_tel.Text = this.musteri.tel;
            this.grp_arama.Visible = false;
            string[] strArray = new string[3]
            {
        "Toptancı",
        "Zaman",
        "Toplam Tutar"
            };
            this.list_toptanci_hareket.ColumnCount = strArray.Length;
            for (int index = 0; index < this.list_toptanci_hareket.ColumnCount; ++index)
                this.list_toptanci_hareket.Columns[index].Name = strArray[index];
            this.items = frm_ana_sayfa.db.tedarik_islemleri.Where(x => x.toptanci_id == musteri.id).ToList();
            this.IslemListele(this.items);
        }

        private void IslemListele(List<tedarik> items)
        {
            items = items.OrderByDescending(i => i.id).ToList();
            this.list_toptanci_hareket.Rows.Clear();
            foreach (tedarik tedarik in items)
            {
                DataGridViewRow row = this.list_toptanci_hareket.Rows[this.list_toptanci_hareket.Rows.Add()];
                row.Cells[0].Value = (object)this.musteri.ad;
                row.Cells[1].Value = (object)tedarik.zaman;
                row.Cells[2].Value = (object)(tedarik.toplam.ToString() + " ₺");
                row.Tag = (object)tedarik;
            }
        }

        private void btn_islem_ekle_Click(object sender, EventArgs e)
        {
            new frm_stok_giris(this.musteri).ShowDialog();
        }

        private void btn_islem_duzenle_Click(object sender, EventArgs e)
        {
            if (this.list_toptanci_hareket.SelectedRows.Count > 0 && this.list_toptanci_hareket.SelectedRows[0].Tag != null)
            {
                frm_stok_giris frmStokGiris = new frm_stok_giris((tedarik)this.list_toptanci_hareket.SelectedRows[0].Tag);
               frmStokGiris.ShowDialog();
                if (frmStokGiris.DialogResult != DialogResult.OK)
                    return;
                this.IslemListele(frm_ana_sayfa.db.tedarik_islemleri.Where<tedarik>((Expression<Func<tedarik, bool>>)(x => x.toptanci_id == this.musteri.id)).ToList<tedarik>());
            }
            else
            {
               MessageBox.Show("Düzenlemek için işlem seçmeniz gerekmekedir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_islem_sil_Click(object sender, EventArgs e)
        {
            if (this.list_toptanci_hareket.SelectedRows.Count > 0 && this.list_toptanci_hareket.SelectedRows[0].Tag != null)
            {
                if (MessageBox.Show("Seçili işlemi silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                tedarik item = (tedarik)this.list_toptanci_hareket.SelectedRows[0].Tag;
                DbSet<stok_giris> stokGirisleri = frm_ana_sayfa.db.stok_girisleri;
                Expression<Func<stok_giris, bool>> predicate = (Expression<Func<stok_giris, bool>>)(s => s.tedarik_id == item.id);
                foreach (stok_giris stokGiris in stokGirisleri.Where<stok_giris>(predicate).ToList<stok_giris>())
                {
                    stok_giris temp = stokGiris;
                    urun urun = frm_ana_sayfa.db.urunler.FirstOrDefault<urun>((Expression<Func<urun, bool>>)(u => u.id == temp.urun_id));
                    if (urun != null)
                    {
                        urun.stok -= temp.adet;
                        urun.stok = urun.stok < 0.0 ? 0.0 : urun.stok;
                    }
                }
                frm_ana_sayfa.db.tedarik_islemleri.Remove(item);
                frm_ana_sayfa.db.SaveChanges();
                this.IslemListele(frm_ana_sayfa.db.tedarik_islemleri.Where<tedarik>((Expression<Func<tedarik, bool>>)(x => x.toptanci_id == this.musteri.id)).ToList<tedarik>());
            }
            else
            {
                int num = (int)MessageBox.Show("Silmek için işlem seçmeniz gerekmekedir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            print.PrintTedarik(this.items, this.txt_toptanci_name.Text, this.txt_toptanci_tel.Text);
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            this.grp_arama.Visible = true;
        }

        private void btn_arama_kapat_Click(object sender, EventArgs e)
        {
            this.grp_arama.Visible = false;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.items = frm_ana_sayfa.db.tedarik_islemleri.ToList<tedarik>().Where<tedarik>((Func<tedarik, bool>)(t =>
            {
                if (this.dt_baslangic.Value <= DateTime.Parse(t.zaman) && DateTime.Parse(t.zaman) <= this.dt_bitis.Value)
                    return t.toptanci_id == this.musteri.id;
                return false;
            })).ToList<tedarik>();
            this.IslemListele(this.items);
        }
    }
}
