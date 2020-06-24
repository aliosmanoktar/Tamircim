using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace Tamircim
{
    public partial class frm_servis_toplam : Form
    {
        List<tamir> tamir;
        List<odemeler> odemeler;
        int servis_id;
        double genel_toplam;
        public frm_servis_toplam(List<tamir> tamir,int servis_id)
        {
            this.servis_id = servis_id;
            this.tamir = tamir;
            InitializeComponent();
        }
        private void frm_servis_toplam_Load(object sender, EventArgs e)
        {
            cmb_servis_durumu.Items.AddRange(new string[] { "Açık", "Parça Bekliyor", "Kapalı" });
            cmb_servis_durumu.SelectedIndex = 0;
            Icon = Properties.Resources.Icon1;
            string[] columns = new string[] { "Tarih","Alınan Ödeme","Ödeme Türü" };
            list_odemeler.ColumnCount = columns.Length;
            for (int i = 0; i < list_odemeler.ColumnCount; i++)
                list_odemeler.Columns[i].Name = columns[i];
            double parca_toplam = 0, iscilik_toplam = 0, kdv = 0, gnl_toplam = 0;
            foreach (tamir item in this.tamir)
            {
                if (item.yedek_parca != null)
                {
                    if (item.iscilik == iscilik_turu.yedek_parca)
                        parca_toplam += item.yedek_parca.fiyat;
                    else iscilik_toplam += item.yedek_parca.fiyat;
                    kdv += ((item.yedek_parca.kdv / 100) * item.yedek_parca.fiyat);
                    gnl_toplam += item.yedek_parca.tutar;
                }
            }

            odemeler = frm_ana_sayfa.db.odemeler.Where(o => o.servis_id == servis_id).ToList();
            servis servis = frm_ana_sayfa.db.servis.Where(s => s.id == servis_id).FirstOrDefault();
            cmb_servis_durumu.SelectedIndex = (int)servis.durum;
            lbl_iscilik_toplam.Text = iscilik_toplam + " ₺";
            lbl_parca_toplam.Text = parca_toplam + " ₺";
            lbl_ara_toplam.Text= (iscilik_toplam + parca_toplam) + " ₺";
            lbl_kdv.Text = kdv + " ₺";
            this.genel_toplam = gnl_toplam;
            lbl_genel_toplam.Text = gnl_toplam + " ₺";
            OdemeAyarla(odemeler);
            
        }
        private void OdemeAyarla(List<odemeler> odemeler)
        {
            list_odemeler.Rows.Clear();
            double toplam = 0;
            foreach(odemeler item in odemeler)
            {
                toplam += item.odeme;
                int index = list_odemeler.Rows.Add();
                DataGridViewRow row = list_odemeler.Rows[index];
                row.Cells[0].Value = item.tarih;
                row.Cells[1].Value = item.odeme + " ₺";
                row.Cells[2].Value = item.odeme_turu == odeme_turu.nakit ? "Nakit" : "Kredi Kartı";
                row.Tag = item;
            }
            lbl_odenecek.Text = (genel_toplam - toplam) + " ₺";
            lbl_odenen.Text = toplam + " ₺";
        }
        private void btn_odeme_ekle_Click(object sender, EventArgs e)
        {
            frm_servis_odeme_ekle frm = new frm_servis_odeme_ekle(servis_id);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                odemeler = frm_ana_sayfa.db.odemeler.Where(o => o.servis_id == servis_id).ToList();
                OdemeAyarla(odemeler);
            }
        }
        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if(list_odemeler.SelectedRows.Count>0 && list_odemeler.SelectedRows[0].Tag != null)
            {
                odemeler item = list_odemeler.SelectedRows[0].Tag as odemeler;
                frm_servis_odeme_ekle frm = new frm_servis_odeme_ekle(item);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    odemeler = frm_ana_sayfa.db.odemeler.Where(o => o.servis_id == servis_id).ToList();
                    OdemeAyarla(odemeler);
                }
            }else
            {
                MessageBox.Show("Düzenlemek için ödeme seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (list_odemeler.SelectedRows.Count > 0 && list_odemeler.SelectedRows[0].Tag != null)
            {
                odemeler item = list_odemeler.SelectedRows[0].Tag as odemeler;
                DialogResult ds = MessageBox.Show("Seçili ödemeyi silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds == DialogResult.Yes)
                {
                    frm_ana_sayfa.db.odemeler.Remove(item);
                    frm_ana_sayfa.db.SaveChanges();
                    odemeler = frm_ana_sayfa.db.odemeler.Where(o => o.servis_id == servis_id).ToList();
                    OdemeAyarla(odemeler);
                }
            }else
            {
                MessageBox.Show("Silmek için ödeme seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmb_servis_durumu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            servis servis = frm_ana_sayfa.db.servis.Where(s => s.id == servis_id).FirstOrDefault();
            if (servis != null)
                servis.durum =(islem_turu)cmb_servis_durumu.SelectedIndex;
            frm_ana_sayfa.db.SaveChanges();
        }
    }
}