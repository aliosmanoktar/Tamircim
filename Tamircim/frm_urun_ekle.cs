using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_urun_ekle : Form
    {
        urun item;
        public frm_urun_ekle()
        {
            InitializeComponent();
        }

        public frm_urun_ekle(urun item)
        {
            this.item = item;
            InitializeComponent();
        }

        private void frm_urun_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (item != null)
            {
                txt_birim.Text = item.birim;
                txt_kdv.Text = item.kdv + "";
                txt_kodu.Text = item.kodu;
                txt_name.Text = item.adi;
                txt_satis.Text = item.satis + "";
                chk_stok_dus.Checked = item.stok_dus;
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            if (item == null)
            {
                item = frm_ana_sayfa.db.urunler.Add(new urun()
                {
                    adi = txt_name.Text,
                    kodu = txt_kodu.Text,
                    birim = txt_birim.Text,
                    kdv = double.Parse(txt_kdv.Text),
                    satis = double.Parse(txt_satis.Text),
                    stok_dus = this.chk_stok_dus.Checked
                });
                frm_ana_sayfa.db.SaveChanges();
            }
            else
            {
                item = frm_ana_sayfa.db.urunler.Where(u => u.id == item.id).FirstOrDefault();
                if (item != null)
                {
                    item.adi = txt_name.Text;
                    item.kodu = txt_kodu.Text;
                    item.birim = txt_birim.Text;
                    item.kdv = double.Parse(txt_kdv.Text);
                    item.satis = double.Parse(txt_satis.Text);
                    item.stok_dus = chk_stok_dus.Checked;
                    frm_ana_sayfa.db.SaveChanges();
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
