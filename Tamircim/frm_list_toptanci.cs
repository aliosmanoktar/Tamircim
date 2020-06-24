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
    public partial class frm_list_toptanci : Form
    {
        bool secim { set; get; }
        public musteri select_toptanci { set; get; }

        public frm_list_toptanci()
        {
            InitializeComponent();
        }

        public frm_list_toptanci(bool secim)
        {
            this.secim = secim;
            InitializeComponent();
        }

        private void frm_list_toptanci_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            cmb_secenekler.Items.AddRange(new string[] { "Ünvan", "Adres", "Telefon" });
            string[] column = { "Ünvanı", "Adres", "Telefon" };
            list_cari.ColumnCount = column.Length;
            for (int i = 0; i < list_cari.ColumnCount; i++)
                list_cari.Columns[i].Name = column[i];
            toptanci_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari == musteri_type.toptanci).ToList());
        }

        private void toptanci_listele(List<musteri> musteris)
        {
            musteris = musteris.OrderByDescending(m => m.id).ToList();
            list_cari.Rows.Clear();
            foreach (musteri item in musteris)
            {
                int index = list_cari.Rows.Add();
                DataGridViewRow row = list_cari.Rows[index];
                row.Cells[0].Value = item.ad;
                row.Cells[1].Value = item.adres;
                row.Cells[2].Value = item.tel;
                row.Tag = item;
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

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            frm_musteri_ekle frm = new frm_musteri_ekle(musteri_type.toptanci);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                toptanci_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari == musteri_type.toptanci).ToList());
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (list_cari.SelectedRows.Count > 0 && list_cari.SelectedRows[0].Tag != null)
            {
                musteri item = list_cari.SelectedRows[0].Tag as musteri;
                frm_musteri_ekle frm = new frm_musteri_ekle(item);
                frm.type = musteri_type.toptanci;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    toptanci_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari == musteri_type.toptanci).ToList());
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (list_cari.SelectedRows.Count > 0 && list_cari.SelectedRows[0].Tag != null)
            {
                DialogResult msg = MessageBox.Show("Seçili Toptancıyı silmek istediğinizden eminmisiniz? \nBu işlem cari ve ona bağlı cari işlemleri silecektir!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    musteri item = list_cari.SelectedRows[0].Tag as musteri;
                    frm_ana_sayfa.db.cari_islemeler.RemoveRange(frm_ana_sayfa.db.cari_islemeler.Where(c => c.musteri_id == item.id).ToList());
                    frm_ana_sayfa.db.musteris.Remove(item);
                    frm_ana_sayfa.db.SaveChanges();
                    toptanci_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari == musteri_type.toptanci).ToList());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_secenekler.SelectedIndex == 0)
                toptanci_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari == musteri_type.toptanci && m.ad.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
            else if (cmb_secenekler.SelectedIndex == 1)
                toptanci_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari == musteri_type.toptanci && m.adres.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
            else if (cmb_secenekler.SelectedIndex == 2)
                toptanci_listele(frm_ana_sayfa.db.musteris.Where(m => m.cari == musteri_type.toptanci && m.tel.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            grp_arama.Visible = false;
            list_cari.Height += grp_arama.Height;
            list_cari.Location = new System.Drawing.Point(list_cari.Location.X, list_cari.Location.Y - grp_arama.Height - 5);
        }

        private void btn_hareket_gor_Click(object sender, EventArgs e)
        {
            if (this.list_cari.SelectedRows.Count > 0 && this.list_cari.SelectedRows[0].Tag != null)
            {
                new frm_list_toptanci_hareket((musteri)this.list_cari.SelectedRows[0].Tag).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hareketleri Listelemek için Toptancı Seçmeniz Gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void list_cari_DoubleClick(object sender, EventArgs e)
        {
            if (this.list_cari.SelectedRows.Count <= 0 || !this.secim || this.list_cari.SelectedRows[0].Tag == null)
                return;
            this.DialogResult = DialogResult.OK;
            this.select_toptanci = (musteri)this.list_cari.SelectedRows[0].Tag;
        }
    }
}