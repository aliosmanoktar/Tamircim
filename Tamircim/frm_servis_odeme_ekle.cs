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
    public partial class frm_servis_odeme_ekle : Form
    {
        odemeler item=null;
        int servis_id;
        public frm_servis_odeme_ekle(odemeler odeme)
        {
            this.item = odeme;
            InitializeComponent();
        }
        public frm_servis_odeme_ekle(int servis_id)
        {
            this.servis_id = servis_id;
            InitializeComponent();
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                item = frm_ana_sayfa.db.odemeler.FirstOrDefault(o => o.id == item.id);
                item.odeme = double.Parse(txt_odeme.Text);
                item.tarih = date_tarih.Text;
                item.odeme_turu = (odeme_turu)cmb_odeme_turu.SelectedIndex;
            }else
            {
                frm_ana_sayfa.db.odemeler.Add(new odemeler()
                {
                    servis_id = servis_id,
                    odeme = double.Parse(txt_odeme.Text),
                    tarih = date_tarih.Text,
                    odeme_turu = (odeme_turu)cmb_odeme_turu.SelectedIndex
                });
            }
            frm_ana_sayfa.db.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void frm_servis_odeme_ekle_Load(object sender, EventArgs e)
        {
            cmb_odeme_turu.Items.AddRange(new string[] { "Nakit", "Kredi Kartı" });
            cmb_odeme_turu.SelectedIndex = 0;
            Icon = Properties.Resources.Icon1;
            if (item != null)
            {
                txt_odeme.Text = item.odeme + "";
                date_tarih.Value = DateTime.Parse(item.tarih);
                cmb_odeme_turu.SelectedIndex = (int)item.odeme_turu;
            }  
        }
    }
}
