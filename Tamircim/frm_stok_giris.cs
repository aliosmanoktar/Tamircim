using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_stok_giris : Form
    {
        private tedarik tedarik;
        private musteri toptanci;
        private List<stok_giris> stoks;
        public frm_stok_giris()
        {
            this.InitializeComponent();
        }

        public frm_stok_giris(musteri musteri)
        {
            this.toptanci = musteri;
            this.InitializeComponent();
        }

        public frm_stok_giris(tedarik tedarik)
        {
            this.tedarik = tedarik;
            this.InitializeComponent();
        }
        private void btn_tedarikci_sec_Click(object sender, EventArgs e)
        {
            frm_list_toptanci frmListToptanci = new frm_list_toptanci(true);
            int num = (int)frmListToptanci.ShowDialog();
            if (frmListToptanci.DialogResult != DialogResult.OK)
                return;
            this.toptanci = frmListToptanci.select_toptanci;
            this.txt_toptanci_name.Text = this.toptanci.ad;
            this.txt_toptanci_tel.Text = this.toptanci.tel;
        }

        private void frm_stok_girisi_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            this.btn_yazdir.Visible = false;
            this.stoks = new List<stok_giris>();
            string[] strArray = new string[7]
            {
        "Kodu",
        "Tedarik Edilen ürün",
        "Birim",
        "KDV",
        "Miktar",
        "Fiyat",
        "Tutar"
            };
            this.list_stok_giris.ColumnCount = strArray.Length;
            for (int index = 0; index < this.list_stok_giris.ColumnCount; ++index)
                this.list_stok_giris.Columns[index].Name = strArray[index];
            if (this.tedarik != null)
            {
                Console.WriteLine(this.tedarik.id);
                this.stoks = frm_ana_sayfa.db.stok_girisleri.Where<stok_giris>((Expression<Func<stok_giris, bool>>)(s => s.tedarik_id == this.tedarik.id)).ToList<stok_giris>();
                this.stoks.ForEach((Action<stok_giris>)(s => s.urun = frm_ana_sayfa.db.urunler.FirstOrDefault<urun>((Expression<Func<urun, bool>>)(u => u.id == s.urun_id))));
                Console.WriteLine(this.stoks.Count);
                this.stok_giris_listele(this.stoks);
                this.toptanci = frm_ana_sayfa.db.musteris.FirstOrDefault<musteri>((Expression<Func<musteri, bool>>)(t => t.id == this.tedarik.toptanci_id));
                this.btn_yazdir.Visible = true;
            }
            if (this.toptanci == null)
                return;
            this.txt_toptanci_name.Text = this.toptanci.ad;
            this.txt_toptanci_tel.Text = this.toptanci.tel;
        }

        private void btn_urun_ekle_Click(object sender, EventArgs e)
        {
            if (this.toptanci == null)
            {
                int num1 = (int)MessageBox.Show("Lütfen Toptancı Seçimi Yapınız!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                frm_stok_ekle frmStokEkle = new frm_stok_ekle(this.toptanci.id);
                int num2 = (int)frmStokEkle.ShowDialog();
                if (frmStokEkle.DialogResult != DialogResult.OK)
                    return;
                this.stoks.Add(frmStokEkle.stok);
                this.stok_giris_listele(this.stoks);
            }
        }

        private void stok_giris_listele(List<stok_giris> stoks)
        {
            this.list_stok_giris.Rows.Clear();
            foreach (stok_giris stok in stoks)
            {
                if (stok.urun != null)
                {
                    DataGridViewRow row = this.list_stok_giris.Rows[this.list_stok_giris.Rows.Add()];
                    row.Cells[0].Value = (object)stok.urun.kodu;
                    row.Cells[1].Value = (object)stok.urun.adi;
                    row.Cells[2].Value = (object)stok.urun.birim;
                    row.Cells[3].Value = (object)("% " + (object)stok.kdv ?? "");
                    row.Cells[4].Value = (object)string.Concat((object)stok.adet);
                    row.Cells[5].Value = (object)stok.fiyat;
                    row.Cells[6].Value = (object)string.Concat((object)stok.tutar);
                    row.Tag = (object)stok;
                }
            }
        }

        private void btn_urun_duzenle_Click(object sender, EventArgs e)
        {
            if (this.list_stok_giris.SelectedRows.Count > 0 && this.list_stok_giris.SelectedRows[0].Tag != null)
            {
                frm_stok_ekle frmStokEkle = new frm_stok_ekle((stok_giris)this.list_stok_giris.SelectedRows[0].Tag);
                int num = (int)frmStokEkle.ShowDialog();
                int index = this.list_stok_giris.SelectedRows[0].Index;
                if (frmStokEkle.DialogResult != DialogResult.OK)
                    return;
                frmStokEkle.stok.id = this.stoks[index].id;
                this.stoks[index] = frmStokEkle.stok;
                this.stok_giris_listele(this.stoks);
            }
            else
            {
                int num1 = (int)MessageBox.Show("Ürünü düzenelmek için öncelikli olarak ürün seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_urun_sil_Click(object sender, EventArgs e)
        {
            if (this.list_stok_giris.SelectedRows.Count > 0 && this.list_stok_giris.SelectedRows[0].Tag != null)
            {
                if (DialogResult.Yes != MessageBox.Show("Seçili ürünü silmek istediğinizden eminmisiniz!!!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    return;
                this.stoks.RemoveAt(this.list_stok_giris.SelectedRows[0].Index);
                if (this.tedarik != null)
                {
                    stok_giris item = (stok_giris)this.list_stok_giris.SelectedRows[0].Tag;
                    frm_ana_sayfa.db.stok_girisleri.Remove(item);
                    urun urun = frm_ana_sayfa.db.urunler.FirstOrDefault<urun>((u => u.id == item.urun_id));
                    urun.stok -= item.adet;
                    urun.stok = urun.stok < 0.0 ? 0.0 : urun.stok;
                    frm_ana_sayfa.db.SaveChanges();
                }
                this.stok_giris_listele(this.stoks);
            }
            else
            {
                int num = (int)MessageBox.Show("Ürünü silmek için öncelikli olarak ürün seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            double toplam = 0.0;
            this.stoks.ForEach((Action<stok_giris>)(x => toplam += x.tutar));
            if (this.tedarik == null)
            {
                tedarik entity = new tedarik()
                {
                    toptanci_id = this.toptanci.id,
                    zaman = DateTime.Now.ToShortDateString(),
                    toplam = toplam
                };
                frm_ana_sayfa.db.tedarik_islemleri.Add(entity);
                frm_ana_sayfa.db.SaveChanges();
                foreach (stok_giris stok in this.stoks)
                {
                    stok.tedarik_id = entity.id;
                    frm_ana_sayfa.db.stok_girisleri.Add(stok);
                }
                List<int> ids = this.stoks.Select<stok_giris, int>((Func<stok_giris, int>)(s => s.urun.id)).ToList<int>();
                frm_ana_sayfa.db.urunler.Where<urun>((x => ids.Contains(x.id))).ToList<urun>().ForEach((Action<urun>)(x => x.stok += this.stoks.FirstOrDefault<stok_giris>((Func<stok_giris, bool>)(s => s.urun.id == x.id)).adet));
                frm_ana_sayfa.db.cari_islemeler.Add(new cari_islemleri()
                {
                    aciklama = "Parça Alımı",
                    borc = toplam,
                    islem = cari_islem.cari_islem,
                    musteri_id = this.toptanci.id,
                    tarih = DateTime.Now.ToShortDateString()
                });
                frm_ana_sayfa.db.SaveChanges();
            }
            else
            {
                frm_ana_sayfa.db.tedarik_islemleri.FirstOrDefault<tedarik>((t => t.id == this.tedarik.id)).toplam = toplam;
                foreach (stok_giris stok in this.stoks)
                {
                    stok_giris item = stok;
                    stok_giris tmp = frm_ana_sayfa.db.stok_girisleri.FirstOrDefault<stok_giris>((s => s.id == item.id));
                    if (tmp == null)
                    {
                        item.tedarik_id = this.tedarik.id;
                        frm_ana_sayfa.db.urunler.FirstOrDefault<urun>((u => u.id == item.urun.id)).stok += item.adet;
                        item.tedarik_id = this.tedarik.id;
                        frm_ana_sayfa.db.stok_girisleri.Add(item);
                    }
                    else
                    {
                        if (tmp.urun_id == item.urun_id)
                        {
                            urun urun = frm_ana_sayfa.db.urunler.FirstOrDefault<urun>(u => u.id == tmp.urun_id);
                            urun.stok -= tmp.adet - item.adet;
                            urun.stok = urun.stok <= 0.0 ? 0.0 : urun.stok;
                        }
                        else
                        {
                            urun urun = frm_ana_sayfa.db.urunler.FirstOrDefault<urun>((u => u.id == tmp.urun.id));
                            urun.stok -= tmp.adet;
                            urun.stok = urun.stok <= 0.0 ? 0.0 : urun.stok;
                        }
                        tmp.adet = item.adet;
                        tmp.fiyat = item.fiyat;
                        tmp.kdv = item.kdv;
                        tmp.tutar = item.tutar;
                        tmp.urun_id = item.urun_id;
                    }
                }
                frm_ana_sayfa.db.cari_islemeler.FirstOrDefault<cari_islemleri>((x => x.musteri_id == this.tedarik.toptanci_id && x.tarih == this.tedarik.zaman)).borc = toplam;
                frm_ana_sayfa.db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            stoks.ForEach(x => x.urun = frm_ana_sayfa.db.urunler.FirstOrDefault(u => u.id == x.urun_id));
            print.PrintStokGiris(stoks, txt_toptanci_name.Text, tedarik.zaman);
        }
    }
}
