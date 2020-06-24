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
    public partial class frm_servis_ekle : Form
    {
        bool update = false;
        musteri musteri;
        servis servis;
        public frm_servis_ekle(musteri musteri)
        {
            this.musteri = musteri;
            InitializeComponent();
        }
        public frm_servis_ekle(servis servis)
        {
            this.servis = servis;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            servis temp = new servis()
            {
                musteri_id = musteri == null ? servis.musteri_id : musteri.id,
                emanet = txt_emanet.Text,
                getiren = txt_getiren.Text,
                km = txt_km.Text,
                saat = date_saat.Value.ToString("HH:mm"),
                tarih = date_tarih.Value.ToShortDateString(),
                yakit = txt_yakit.Text,
            };
            if(update)
            {
                temp = frm_ana_sayfa.db.servis.Where(s => s.id == servis.id).FirstOrDefault();
                temp.emanet = txt_emanet.Text;
                temp.getiren = txt_getiren.Text;
                temp.km = txt_km.Text;
                temp.saat = date_saat.Value.ToString("HH:mm");
                temp.tarih = date_tarih.Value.ToShortDateString();
                temp.yakit = txt_yakit.Text;

            }
            else
            {
                frm_ana_sayfa.db.servis.Add(temp);
            }
            frm_ana_sayfa.db.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void frm_servis_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (musteri != null)
                txt_getiren.Text = musteri.ad;
            else if (servis != null)
            {
                update = true;
                txt_emanet.Text = servis.emanet;
                txt_getiren.Text = servis.getiren;
                txt_km.Text = servis.km;
                txt_yakit.Text = servis.yakit;
                date_saat.Value = DateTime.Parse(servis.saat);
                date_tarih.Value = DateTime.Parse(servis.tarih);
            }
        }
    }
}
