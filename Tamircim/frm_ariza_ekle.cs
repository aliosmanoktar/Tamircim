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
    public partial class frm_ariza_ekle : Form
    {
        arizalar ariza=null;
        int servis_id;
        public frm_ariza_ekle(int id)
        {
            servis_id = id;
            InitializeComponent();
        }
        public frm_ariza_ekle(arizalar ariza)
        {
            this.ariza = ariza;
            InitializeComponent();
        }

        private void frm_ariza_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (ariza != null)
                txt_ariza.Text = ariza.ariza;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (ariza == null)
            {
                frm_ana_sayfa.db.arizalar.Add(new arizalar()
                {
                    servis_id = servis_id,
                    ariza = txt_ariza.Text,
                });
                frm_ana_sayfa.db.SaveChanges();
            }
            else
            {
                arizalar ariza = frm_ana_sayfa.db.arizalar.FirstOrDefault(a => a.id == this.ariza.id);
                ariza.ariza = txt_ariza.Text;
                frm_ana_sayfa.db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
