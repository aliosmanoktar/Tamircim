using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_personel_ucret_tarih : Form
    {
        personel personel=null;
        public frm_personel_ucret_tarih()
        {
            InitializeComponent();
        }

        private void frm_personel_ucret_tarih_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            dt_bitis.MaxDate = DateTime.Now;
            dt_baslangic.MaxDate = DateTime.Now.AddDays(-1);
            dt_baslangic.Value = DateTime.Now.AddMonths(-1);
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            if(personel==null)
                print.PrintPersonelUcret(frm_ana_sayfa.db.personel_islemleri.ToList().Where(c => dt_baslangic.Value <= DateTime.Parse(c.tarih) && DateTime.Parse(c.tarih) <= dt_bitis.Value).ToList(), dt_baslangic.Text + " - " + dt_bitis.Text);
            else
                print.PrintPersonelUcret(frm_ana_sayfa.db.personel_islemleri.ToList().Where(c => dt_baslangic.Value <= DateTime.Parse(c.tarih) && DateTime.Parse(c.tarih) <= dt_bitis.Value && c.personel_id==personel.id).ToList(), dt_baslangic.Text + " - " + dt_bitis.Text);
        }
    
        private void btn_personel_listele_Click(object sender, EventArgs e)
        {
            frm_personel_list frm = new frm_personel_list(true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                personel = frm.select_personel;
                txt_personel.Text = personel.ad;
            }
        }

        private void txt_personel_TextChanged(object sender, EventArgs e)
        {
            if (txt_personel.Text.Length == 0)
                personel = null;
        }
    }
}
