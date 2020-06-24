using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_servise_gelen_arac : Form
    {
        public frm_servise_gelen_arac()
        {
            InitializeComponent();
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
             print.PrintServiseGelenArac(frm_ana_sayfa.db.servis.ToList().Where(c => dt_baslangic.Value <= DateTime.Parse(c.tarih) && DateTime.Parse(c.tarih) <= dt_bitis.Value).ToList(), dt_baslangic.Text + " - " + dt_bitis.Text);
        }

        private void frm_servise_gelen_arac_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            dt_bitis.MaxDate = DateTime.Now;
            dt_baslangic.MaxDate = DateTime.Now.AddDays(-1);
            dt_baslangic.Value = DateTime.Now.AddMonths(-1);
        }
    }
}
