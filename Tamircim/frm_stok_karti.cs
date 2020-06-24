using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_stok_karti : Form
    {
        List<urun> urunler;
        bool secim;
        public urun select_item;
        public frm_stok_karti(bool secim)
        {
            this.secim = secim;
            InitializeComponent();
        }
        

        private void frm_stok_karti_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            cmb_secenekler.Items.AddRange(new string[]{ "Kod Arama", "Ad Arama"});
            cmb_secenekler.SelectedIndex = 0;
            string[] column = { "Kodu", "Adı", "Birim", "KDV", "Fiyat","Stok","Not" };
            list_stoklar.ColumnCount = column.Length;
            for (int i = 0; i < list_stoklar.ColumnCount; i++)
                list_stoklar.Columns[i].Name = column[i];
            list_stoklar_Resize(null, null);
            UrunListele(frm_ana_sayfa.db.urunler.Where(u=> !u.sil ).ToList());
        }

        void UrunListele(List<urun> urunler)
        {
            this.urunler = urunler;
            list_stoklar.Rows.Clear();
            foreach(urun item in urunler)
            {
                int index = list_stoklar.Rows.Add();
                DataGridViewRow row = list_stoklar.Rows[index];
                row.Cells[0].Value = item.kodu;
                row.Cells[1].Value = item.adi;
                row.Cells[2].Value = item.birim;
                row.Cells[3].Value = item.kdv;
                row.Cells[4].Value = item.satis+" ₺";
                row.Cells[5].Value = item.stok+"";
                row.Cells[6].Value = item.not;
                row.Tag = item;
            }
            if (list_stoklar.SelectedRows.Count > 0)
                list_stoklar.SelectedRows[0].Selected = false;
        }

        private void list_stoklar_Resize(object sender, EventArgs e)
        {
            int size = list_stoklar.Width / (list_stoklar.Columns.Count + 4);
            for (int i = 0; i < list_stoklar.Columns.Count; i++)
                if (i == 1)
                    list_stoklar.Columns[i].Width = size * 5;
                else
                    list_stoklar.Columns[i].Width = size;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            frm_urun_ekle frm = new frm_urun_ekle();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                UrunListele(frm_ana_sayfa.db.urunler.Where(u => !u.sil).ToList());
            }
        }

        private void btn_duzelt_Click(object sender, EventArgs e)
        {
            if (list_stoklar.SelectedRows.Count > 0 && list_stoklar.SelectedRows[0].Tag != null)
            {
                urun item = (urun)list_stoklar.SelectedRows[0].Tag;
                frm_urun_ekle frm = new frm_urun_ekle(item);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    UrunListele(frm_ana_sayfa.db.urunler.Where(u => !u.sil).ToList());
                }
            }
        }

        private void list_stoklar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(secim && list_stoklar.SelectedRows.Count>0 && list_stoklar.SelectedRows[0].Tag!=null)
            {
                select_item =(urun) list_stoklar.SelectedRows[0].Tag;
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (list_stoklar.SelectedRows.Count > 0 && list_stoklar.SelectedRows[0].Tag != null)
            {
                DialogResult ds = MessageBox.Show("Seçili Ürünü silmek istediğinizden eminmisiniz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds != DialogResult.Yes)
                    return;
                select_item = list_stoklar.SelectedRows[0].Tag as urun;
                urun temp = frm_ana_sayfa.db.urunler.FirstOrDefault(u => u.id == select_item.id);
                temp.sil = true;
                frm_ana_sayfa.db.SaveChanges();
                UrunListele(frm_ana_sayfa.db.urunler.Where(u => !u.sil).ToList());
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            grp_arama.Visible = false;
            list_stoklar.Height += grp_arama.Height;
            list_stoklar.Location = new System.Drawing.Point(list_stoklar.Location.X ,list_stoklar.Location.Y-grp_arama.Height-5);
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (grp_arama.Visible)
                return;
            cmb_secenekler.SelectedIndex = 0;
            txt_aranan.Text = "";
            grp_arama.Visible = true;
            list_stoklar.Height -= grp_arama.Height;
            list_stoklar.Location = new System.Drawing.Point(list_stoklar.Location.X , list_stoklar.Location.Y + grp_arama.Height+5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmb_secenekler.SelectedIndex==0)
                UrunListele(frm_ana_sayfa.db.urunler.Where(u => !u.sil && u.kodu.Contains(txt_aranan.Text)).ToList());
            else UrunListele(frm_ana_sayfa.db.urunler.Where(u => !u.sil && u.adi.Contains(txt_aranan.Text)).ToList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            print.PrintStok(this.urunler);
        }
    }
}
