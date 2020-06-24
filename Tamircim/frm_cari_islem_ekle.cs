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
    public partial class frm_cari_islem_ekle : Form
    {
        musteri item;
        cari_islemleri islem;
        public frm_cari_islem_ekle()
        {
            InitializeComponent();
        }
        public frm_cari_islem_ekle(cari_islemleri islem)
        {
            this.islem = islem;
            InitializeComponent();
        }

        private void frm_cari_islem_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            cmb_islem_turu.Items.AddRange(new string[] {"Cari İşlem","Nakit İşlem"});
            cmb_islem_turu.SelectedIndex = 0;
            tarih.MaxDate = DateTime.Now;
            if (islem != null)
            {
                tarih.Value = DateTime.Parse(islem.tarih);
                cmb_islem_turu.SelectedIndex = (int)islem.islem;
                txt_aciklama.Text = islem.aciklama;
                txt_alacak.Text = "" + islem.alacak;
                txt_borc.Text = "" + islem.borc;
                item = frm_ana_sayfa.db.musteris.FirstOrDefault(m => m.id == islem.musteri_id);
                txt_unvan.Text = item.ad;
            }

        }
        
        private void btn_cari_listele_Click(object sender, EventArgs e)
        {
            frm_list_cari frm = new frm_list_cari(true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                item = frm.cari;
                txt_unvan.Text = item.ad;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            double borc = double.Parse(txt_borc.Text.Length==0 ? "0":txt_borc.Text);
            double alacak = double.Parse(txt_alacak.Text.Length==0 ? "0":txt_alacak.Text);
            if (islem == null)
            {
                cari_islemleri islemleri = new cari_islemleri()
                {
                    aciklama = txt_aciklama.Text,
                    alacak = alacak,
                    borc = borc,
                    islem = (cari_islem)cmb_islem_turu.SelectedIndex,
                    musteri_id = item.id,
                    tarih = tarih.Text
                };
                frm_ana_sayfa.db.cari_islemeler.Add(islemleri);
            }
            else
            {
                cari_islemleri cr_islem = frm_ana_sayfa.db.cari_islemeler.FirstOrDefault(c => c.id == islem.id);
                cr_islem.aciklama = txt_aciklama.Text;
                cr_islem.alacak = alacak;
                cr_islem.borc = borc;
                cr_islem.islem = (cari_islem)cmb_islem_turu.SelectedIndex;
                cr_islem.musteri_id = item.id;
                cr_islem.tarih = tarih.Text;
            }
            frm_ana_sayfa.db.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }
    }
}
