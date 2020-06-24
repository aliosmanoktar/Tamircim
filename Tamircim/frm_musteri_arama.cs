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
    public partial class frm_musteri_arama : Form
    {
        public List<musteri> musteriler { set; get; }
        public frm_musteri_arama()
        {
            InitializeComponent();
        }

        private void frm_musteri_arama_Load(object sender, EventArgs e)
        {
            cmb_arama_secenekleri.Items.AddRange(new string[] { "Ünvan", "Plaka", "Model", "Telefon", "Şasi No", "Motor No" });
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cmb_arama_secenekleri.SelectedIndex);
            string aranan = txt_aranan.Text;
            if (cmb_arama_secenekleri.SelectedIndex == 0) //unvan
                musteriler = frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci && m.ad.ToLower().Contains(aranan)).ToList();
            else if(cmb_arama_secenekleri.SelectedIndex==1) //plaka
                musteriler = frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci && m.plaka.ToLower().Contains(aranan)).ToList();
            else if(cmb_arama_secenekleri.SelectedIndex==2)//model
                musteriler = frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci && m.model.ToLower().Contains(aranan)).ToList();
            else if(cmb_arama_secenekleri.SelectedIndex==3) //telefon
                musteriler = frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci && m.tel.ToLower().Contains(aranan)).ToList();
            else if(cmb_arama_secenekleri.SelectedIndex==4)//Şasi No
                musteriler = frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci && m.sasi.ToLower().Contains(aranan)).ToList();
            else if(cmb_arama_secenekleri.SelectedIndex==5)//Motor No
                musteriler = frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci && m.motor.ToLower().Contains(aranan)).ToList();
            else //hepsi
                musteriler = frm_ana_sayfa.db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci).ToList();
            this.DialogResult = DialogResult.OK;
        }
    }
}
