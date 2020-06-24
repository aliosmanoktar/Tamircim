using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_list_cari : Form
    {
        public musteri cari;
        public bool secim;

        public frm_list_cari()
        {
            InitializeComponent();
        }

        public frm_list_cari(bool secim)
        {
            this.secim = secim;
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            frm_musteri_ekle frm = new frm_musteri_ekle(musteri_type.cari);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                cari_listele(frm_ana_sayfa.db.musteris.Where(m=> m.cari != musteri_type.musteri).ToList());
            }
        }

        private void cari_listele(List<musteri> musteris)
        {
            musteris = musteris.OrderByDescending(m => m.id).ToList();
            list_cari.Rows.Clear();
            foreach(musteri item in musteris)
            {
                int index = list_cari.Rows.Add();
                DataGridViewRow row = list_cari.Rows[index];
                row.Cells[0].Value = item.ad;
                row.Cells[1].Value = item.adres;
                row.Cells[2].Value = item.tel;
                row.Tag = item;
            }
        }

        private void frm_list_cari_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            cmb_secenekler.Items.AddRange(new string[] { "Ünvan", "Adres", "Telefon" });
            string[] column = { "Ünvanı", "Adres", "Telefon" };
            list_cari.ColumnCount = column.Length;
            for (int i = 0; i < list_cari.ColumnCount; i++)
                list_cari.Columns[i].Name = column[i];
            cari_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.musteri).ToList());

        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (list_cari.SelectedRows.Count > 0 && list_cari.SelectedRows[0].Tag != null)
            {
                musteri item = list_cari.SelectedRows[0].Tag as musteri;
                frm_musteri_ekle frm = new frm_musteri_ekle(item);
                frm.type = musteri_type.cari;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    cari_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.musteri).ToList());
                }
            }
        }

        private void list_cari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (secim)
            {
                if(list_cari.SelectedRows.Count>0 && list_cari.SelectedRows[0].Tag != null)
                {
                    cari =(musteri) list_cari.SelectedRows[0].Tag;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (list_cari.SelectedRows.Count > 0 && list_cari.SelectedRows[0].Tag != null)
            {
                DialogResult msg = MessageBox.Show("Seçili cariyi silmek istediğinizden eminmisiniz? \nBu işlem cari ve ona bağlı cari işlemleri silecektir!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    musteri item = list_cari.SelectedRows[0].Tag as musteri;
                    frm_ana_sayfa.db.cari_islemeler.RemoveRange(frm_ana_sayfa.db.cari_islemeler.Where(c => c.musteri_id == item.id).ToList());
                    frm_ana_sayfa.db.musteris.Remove(item);
                    frm_ana_sayfa.db.SaveChanges();
                    cari_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.musteri).ToList());
                }
            }
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            if (grp_arama.Visible)
                return;
            cmb_secenekler.SelectedIndex = 0;
            txt_aranan.Text = "";
            grp_arama.Visible = true;
            list_cari.Height -= grp_arama.Height;
            list_cari.Location = new System.Drawing.Point(list_cari.Location.X, list_cari.Location.Y + grp_arama.Height + 5);
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            grp_arama.Visible = false;
            list_cari.Height += grp_arama.Height;
            list_cari.Location = new System.Drawing.Point(list_cari.Location.X, list_cari.Location.Y - grp_arama.Height - 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmb_secenekler.SelectedIndex==0)
                cari_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.musteri && m.ad.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
            else if(cmb_secenekler.SelectedIndex==1)
                cari_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.musteri && m.adres.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
            else if(cmb_secenekler.SelectedIndex == 2)
                cari_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.musteri && m.tel.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
        }

        private void btn_hareket_gor_Click(object sender, EventArgs e)
        {
            if(list_cari.SelectedRows.Count>0 && list_cari.SelectedRows[0].Tag != null)
            {
                musteri item = list_cari.SelectedRows[0].Tag as musteri;
                new frm_cari_islem(item).ShowDialog();
            }
            else
            {
                MessageBox.Show("Cari Hareketlerini görebilmeniz için cari seçmeniz gerekmektedir", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}