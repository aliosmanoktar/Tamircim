using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_cari_islem : Form
    {
        musteri item = null;

        public frm_cari_islem()
        {
            InitializeComponent();
        }

        public frm_cari_islem(musteri musteri)
        {
            item = musteri;
            InitializeComponent();
        }

        private void frm_cari_islem_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (item != null)
            {
                btn_ekle.Visible = btn_duzenle.Visible = btn_sil.Visible = false;
                list_cari_islem.Location = new Point(list_cari_islem.Location.X, list_cari_islem.Location.Y - btn_sil.Height + 5); ;
            }
            string[] column = { "Türü", "Ünvanı", "Tarih", "Açıklama", "Borç", "Ödenen" };
            list_cari_islem.ColumnCount = column.Length;
            for (int i = 0; i < list_cari_islem.ColumnCount; i++)
                list_cari_islem.Columns[i].Name = column[i];
            if (item == null)
                cari_islem_listele(frm_ana_sayfa.db.cari_islemeler.ToList());
            else cari_islem_listele(frm_ana_sayfa.db.cari_islemeler.Where(c => c.musteri_id == item.id).ToList());
        }

        private void cari_islem_listele(List<cari_islemleri> islemler)
        {
            islemler = islemler.OrderByDescending(i => i.id).ToList();
            list_cari_islem.Rows.Clear();
            foreach(cari_islemleri item in islemler)
            {
                int index = list_cari_islem.Rows.Add();
                DataGridViewRow row = list_cari_islem.Rows[index];
                string tur = "";
                if (item.islem == cari_islem.cari_islem)
                    tur = "Cari İşlem";
                else if (item.islem == cari_islem.servis)
                    tur = "Servis";
                else if (item.islem == cari_islem.nakit)
                    tur = "Nakit";
                row.Cells[0].Value = tur;
                musteri musteri = frm_ana_sayfa.db.musteris.FirstOrDefault(m => m.id == item.musteri_id);
                row.Cells[1].Value = musteri.ad;
                row.Cells[2].Value = item.tarih;
                row.Cells[3].Value = item.aciklama;
                row.Cells[4].Value = item.borc+" ₺";
                row.Cells[5].Value = item.alacak+" ₺";
                row.Tag = item;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            frm_cari_islem_ekle frm = new frm_cari_islem_ekle();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                cari_islem_listele(frm_ana_sayfa.db.cari_islemeler.ToList());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(list_cari_islem.SelectedRows.Count>0 && list_cari_islem.SelectedRows[0].Tag!=null)
            {
                frm_cari_islem_ekle frm = new frm_cari_islem_ekle((cari_islemleri)list_cari_islem.SelectedRows[0].Tag);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    cari_islem_listele(frm_ana_sayfa.db.cari_islemeler.ToList());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(list_cari_islem.SelectedRows.Count > 0 && list_cari_islem.SelectedRows[0].Tag != null)
            {
                DialogResult ds = MessageBox.Show("Seçili Cari işlemini silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds == DialogResult.Yes)
                {
                    cari_islemleri islem = list_cari_islem.SelectedRows[0].Tag as cari_islemleri;
                    frm_ana_sayfa.db.cari_islemeler.Remove(islem);
                    frm_ana_sayfa.db.SaveChanges();
                    cari_islem_listele(frm_ana_sayfa.db.cari_islemeler.ToList());
                }
            }
        }
    }
}