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
    public partial class frm_musteri_ekle : Form
    {
        public musteri_type type;
        musteri item;
        public frm_musteri_ekle(musteri_type type)
        {
            this.type = type;
            InitializeComponent();
        }
        public frm_musteri_ekle(musteri musteri)
        {
            item = musteri;
            this.type = musteri.cari;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (item == null)
            {
                musteri musteri = frm_ana_sayfa.db.musteris.Add(new musteri()
                {
                    ad = txt_name.Text,
                    adres = txt_adres.Text,
                    cari = type,
                    email = txt_email.Text,
                    model = txt_model.Text,
                    not = txt_not.Text,
                    plaka = txt_plaka.Text,
                    sasi = txt_sasi_no.Text,
                    vergi_dairesi = txt_vergi_dairesi.Text,
                    vergi_no = txt_vergi_no.Text,
                    tel = txt_tel.Text,
                    motor = txt_motor.Text

                });
            }
            else
            {
                musteri musteri = frm_ana_sayfa.db.musteris.FirstOrDefault(m => m.id == item.id);
                musteri.ad = txt_name.Text;
                musteri.adres = txt_adres.Text;
                musteri.cari = item.cari;
                musteri.email = txt_email.Text;
                musteri.model = txt_model.Text;
                musteri.not = txt_not.Text;
                musteri.plaka = txt_plaka.Text;
                musteri.sasi = txt_sasi_no.Text;
                musteri.vergi_dairesi = txt_vergi_dairesi.Text;
                musteri.vergi_no = txt_vergi_no.Text;
                musteri.tel = txt_tel.Text;
                musteri.motor = txt_motor.Text;
            }
            frm_ana_sayfa.db.SaveChanges();
            this.DialogResult=DialogResult.OK;
        }

        private void frm_musteri_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (item != null)
            {
                txt_adres.Text = item.adres;
                txt_email.Text = item.email;
                txt_model.Text = item.model;
                txt_motor.Text = item.motor;
                txt_name.Text = item.ad;
                txt_not.Text = item.not;
                txt_plaka.Text = item.plaka;
                txt_sasi_no.Text = item.sasi;
                txt_tel.Text = item.tel;
                txt_vergi_dairesi.Text = item.vergi_dairesi;
                txt_vergi_no.Text = item.vergi_no;
                btn_cari_sec.Visible = false;
            }
            if (!(type==musteri_type.musteri ||type==musteri_type.cari_musteri))
            {
                groupBox2.Visible = false;
                this.Height -= 141;
                groupBox1.Text = "Firma Bilgileri";
                btn_cari_sec.Visible = false;
                Text = "Firma Ekle";

            }
        }

        private void btn_cari_sec_Click(object sender, EventArgs e)
        {
            frm_list_cari frm = new frm_list_cari(true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                item = frm.cari;
                if (item.cari == musteri_type.cari_musteri)
                {
                    MessageBox.Show("Seçilen cari için müşteri kaydı zaten açılmış");
                    item = null;
                    return;
                    
                }
                txt_adres.Text = item.adres;
                txt_adres.Text = item.adres;
                txt_email.Text = item.email;
                txt_model.Text = item.model;
                txt_motor.Text = item.motor;
                txt_name.Text = item.ad;
                txt_not.Text = item.not;
                txt_plaka.Text = item.plaka;
                txt_sasi_no.Text = item.sasi;
                txt_tel.Text = item.tel;
                txt_vergi_dairesi.Text = item.vergi_dairesi;
                txt_vergi_no.Text = item.vergi_no;
                item.cari = musteri_type.cari_musteri;
            }
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
