using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_cari_ekstre_yazdir : Form
    {
        public frm_cari_ekstre_yazdir()
        {
            InitializeComponent();
        }
        musteri item = null;
        private void btn_cari_listele_Click(object sender, EventArgs e)
        {
            frm_list_cari frm = new frm_list_cari(true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                item = frm.cari;
                txt_cari.Text = frm.cari.ad;
            }
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            if (txt_cari.Text.Length == 0)
                item = null;
        }

        private void frm_cari_ekstre_yazdir_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            dt_bitis.MaxDate = DateTime.Now;
            dt_baslangic.MaxDate = DateTime.Now.AddDays(-1);
            dt_baslangic.Value = DateTime.Now.AddMonths(-1);
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            if(item!=null)
                print.PrintCariEkstre(frm_ana_sayfa.db.cari_islemeler.ToList().Where(c =>c.musteri_id==item.id && dt_baslangic.Value <= DateTime.Parse(c.tarih) && DateTime.Parse(c.tarih) <= dt_bitis.Value).ToList(), item, dt_baslangic.Text + " - " + dt_bitis.Text);
            else print.PrintCariEkstre(frm_ana_sayfa.db.cari_islemeler.ToList().Where(c=> dt_baslangic.Value <= DateTime.Parse(c.tarih) && DateTime.Parse(c.tarih) <= dt_bitis.Value).ToList(), dt_baslangic.Text + " - " + dt_bitis.Text);
        }
    }
}
