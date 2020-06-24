using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_parca_ekle : Form
    {
        int id;
        yedek_parca parca;
        urun item;
        iscilik_turu tur;
        public frm_parca_ekle(int id,iscilik_turu tur)
        {
            this.tur = tur;
            this.id = id;
            InitializeComponent();
        }
        public frm_parca_ekle(yedek_parca parca,iscilik_turu tur)
        {
            this.tur = tur;
            InitializeComponent();
            this.parca = parca;
        }

        private void btn_stok_listele_Click(object sender, EventArgs e)
        {

            frm_stok_karti frm = new frm_stok_karti(true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                item = frm.select_item;
                this.txt_stok_kodu.Text = frm.select_item.kodu;
                txt_birim.Text = frm.select_item.birim;
                txt_parca.Text = frm.select_item.adi;
                txt_kdv.Text = item.kdv+"";
                txt_fiyat.Text = item.satis+"";
            }
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (parca == null)
            {
                var tamir = frm_ana_sayfa.db.tamirler.Add(new tamir()
                {
                    iscilik = tur,
                    servis_id = id
                });
                frm_ana_sayfa.db.SaveChanges();
                yedek_parca yedekParca =frm_ana_sayfa.db.yedek_parca.Add(new yedek_parca()
                {
                    adet = double.Parse(txt_miktar.Text),
                    tamir_id = tamir.id,
                    tutar = double.Parse(txt_tutar.Text.Replace("₺","")),
                    urun = item,
                    urun_id = item.id,
                    fiyat = double.Parse(txt_fiyat.Text),
                    kdv = double.Parse(txt_kdv.Text)
                });
                if (this.item.stok_dus)
                {
                    urun urun = frm_ana_sayfa.db.urunler.FirstOrDefault<urun>((Expression<Func<urun, bool>>)(u => u.id == this.item.id));
                    urun.stok -= yedekParca.adet;
                    urun.stok = urun.stok < 0.0 ? 0.0 : urun.stok;
                }
                frm_ana_sayfa.db.SaveChanges();
            }
            else
            {
                double adet = this.parca.adet;
                yedek_parca yedekParca = frm_ana_sayfa.db.yedek_parca.FirstOrDefault<yedek_parca>((Expression<Func<yedek_parca, bool>>)(y => y.id == this.parca.id));
                yedek_parca temp = frm_ana_sayfa.db.yedek_parca.FirstOrDefault(y => y.id == parca.id);
                temp.adet = double.Parse(txt_miktar.Text);
                temp.tamir_id = parca.tamir_id;
                temp.tutar = double.Parse(txt_tutar.Text.Replace("₺",""));
                temp.urun = item;
                temp.urun_id = item.id;
                temp.fiyat = double.Parse(txt_fiyat.Text);
                temp.kdv = double.Parse(txt_kdv.Text);
                frm_ana_sayfa.db.SaveChanges();
                if (this.item.stok_dus)
                {
                    urun urun = frm_ana_sayfa.db.urunler.FirstOrDefault<urun>((Expression<Func<urun, bool>>)(u => u.id == this.item.id));
                    urun.stok += adet - yedekParca.adet;
                    urun.stok = urun.stok < 0.0 ? 0.0 : urun.stok;
                    Console.WriteLine(adet - yedekParca.adet);
                    Console.WriteLine(urun.stok);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void frm_parca_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            txt_miktar.Text = 1 + "";
            if (parca != null)
            {
                txt_birim.Text = parca.urun.birim;
                txt_miktar.Text = parca.adet + "";
                txt_parca.Text = parca.urun.adi;
                txt_stok_kodu.Text = parca.urun.kodu;
                txt_fiyat.Text = parca.fiyat + "";
                item = parca.urun;
                txt_kdv.Text = parca.kdv + "";
            }
        }

        private void btn_stok_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                urun itm_urun = new urun()
                {
                    adi = txt_parca.Text,
                    birim = txt_birim.Text,
                    kdv = double.Parse(txt_kdv.Text),
                    kodu = txt_stok_kodu.Text,
                    satis = (double.Parse(txt_fiyat.Text)),
                    stok_dus = DialogResult.Yes == MessageBox.Show("Soru", "Ürün stoktan düşecekmi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                };
                this.item = itm_urun;
                frm_ana_sayfa.db.urunler.Add(itm_urun);
                frm_ana_sayfa.db.SaveChanges();
                btn_kaydet_Click(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Gerekli Alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_kdv_TextChanged(object sender, EventArgs e)
        {

            double kdv = double.Parse(txt_kdv.Text.Length==0 ? "0" : txt_kdv.Text);
            double birim = double.Parse(txt_miktar.Text.Length==0 ? "1":txt_miktar.Text);
            double fiyat = double.Parse(txt_fiyat.Text.Length == 0 ? "0":txt_fiyat.Text);
            txt_tutar.Text = "" + ((fiyat+(fiyat * (kdv/100))) * birim)+" ₺";
        }

        private void txt_kdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
