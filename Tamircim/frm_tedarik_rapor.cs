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
    public partial class frm_tedarik_rapor : Form
    {
        private musteri tedarikci;
        public frm_tedarik_rapor()
        {
            InitializeComponent();
        }
        private void btn_tedarikci_listele_Click(object sender, EventArgs e)
        {
            frm_list_toptanci frmListToptanci = new frm_list_toptanci(true);
            int num = (int)frmListToptanci.ShowDialog();
            if (frmListToptanci.DialogResult != DialogResult.OK)
                return;
            this.tedarikci = frmListToptanci.select_toptanci;
            this.txt_cari.Text = this.tedarikci.ad;
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            if (this.tedarikci != null)
                print.PrintTedarik(frm_ana_sayfa.db.tedarik_islemleri.ToList<tedarik>().Where<tedarik>((Func<tedarik, bool>)(t =>
                {
                    if (this.dt_baslangic.Value <= DateTime.Parse(t.zaman) && DateTime.Parse(t.zaman) <= this.dt_bitis.Value)
                        return t.toptanci_id == this.tedarikci.id;
                    return false;
                })).ToList<tedarik>(), this.tedarikci.ad, this.tedarikci.tel);
            else
                print.PrintTedarik(frm_ana_sayfa.db.tedarik_islemleri.ToList<tedarik>().Where<tedarik>((Func<tedarik, bool>)(t =>
                {
                    if (this.dt_baslangic.Value <= DateTime.Parse(t.zaman))
                        return DateTime.Parse(t.zaman) <= this.dt_bitis.Value;
                    return false;
                })).ToList<tedarik>());
        }

        private void frm_tedarik_rapor_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            this.dt_bitis.MaxDate = DateTime.Now;
            this.dt_baslangic.MaxDate = DateTime.Now.AddDays(-1.0);
            this.dt_baslangic.Value = DateTime.Now.AddMonths(-1);
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_cari.Text.Length != 0)
                return;
            this.tedarikci = (musteri)null;
        }
    }
}
