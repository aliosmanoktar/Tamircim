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
    public partial class frm_personel_ekle : Form
    {
        personel item;
        public frm_personel_ekle()
        {
            InitializeComponent();
        }

        public frm_personel_ekle(personel personel)
        {
            item = personel;
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                item = new personel()
                {
                    ad = txt_ad.Text,
                    adres = txt_adres.Text,
                    bolum = txt_bolum.Text,
                    telefon = txt_tel.Text,
                    ucret = double.Parse(txt_ucret.Text)
                };
                frm_ana_sayfa.db.personels.Add(item);
            }
            else
            {
                item = frm_ana_sayfa.db.personels.FirstOrDefault(p => p.id == item.id);
                item.ad = txt_ad.Text;
                item.adres = txt_adres.Text;
                item.bolum = txt_bolum.Text;
                item.telefon = txt_tel.Text;
                item.ucret = double.Parse(txt_ucret.Text);
            }
            frm_ana_sayfa.db.SaveChanges();
            this.DialogResult=DialogResult.OK;
        }

        private void frm_personel_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (item != null)
            {
                txt_ad.Text = item.ad;
                txt_adres.Text = item.adres;
                txt_bolum.Text = item.bolum;
                txt_tel.Text = item.telefon;
                txt_ucret.Text = item.ucret + "";
            }
        }
    }
}
