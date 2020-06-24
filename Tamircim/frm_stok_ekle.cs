using System;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_stok_ekle : Form
    {
        private urun item;
        public stok_giris stok;
        public frm_stok_ekle()
        {
            InitializeComponent();
        }
        private int musteri_id { set; get; }

        public frm_stok_ekle(int musteri_id)
        {
            this.InitializeComponent();
            this.musteri_id = musteri_id;
        }

        public frm_stok_ekle(stok_giris stok)
        {
            this.InitializeComponent();
            this.item = stok.urun;
            this.stok = stok;
        }

        private void frm_stok_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            this.txt_miktar.Text = string.Concat((object)1);
            if (this.stok == null)
                return;
            this.txt_birim.Text = this.stok.urun.birim;
            this.txt_miktar.Text = string.Concat((object)this.stok.adet);
            this.txt_parca.Text = this.stok.urun.adi;
            this.txt_stok_kodu.Text = this.stok.urun.kodu;
            this.txt_fiyat.Text = string.Concat((object)this.stok.fiyat);
            this.item = this.stok.urun;
            this.txt_kdv.Text = string.Concat((object)this.stok.kdv);
        }

        private void btn_stok_listele_Click(object sender, EventArgs e)
        {
            frm_stok_karti frmStokKarti = new frm_stok_karti(true);
            int num = (int)frmStokKarti.ShowDialog();
            if (frmStokKarti.DialogResult != DialogResult.OK)
                return;
            this.item = frmStokKarti.select_item;
            this.txt_stok_kodu.Text = frmStokKarti.select_item.kodu;
            this.txt_birim.Text = frmStokKarti.select_item.birim;
            this.txt_parca.Text = frmStokKarti.select_item.adi;
            this.txt_kdv.Text = string.Concat((object)this.item.kdv);
            this.txt_fiyat.Text = string.Concat((object)this.item.satis);
        }

        private void btn_stok_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                urun entity = new urun()
                {
                    adi = this.txt_parca.Text,
                    birim = this.txt_birim.Text,
                    kdv = double.Parse(this.txt_kdv.Text),
                    kodu = this.txt_stok_kodu.Text,
                    satis = double.Parse(this.txt_fiyat.Text),
                    stok_dus = DialogResult.Yes == MessageBox.Show("Soru", "Ürün stoktan düşecekmi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                };
                this.item = entity;
                frm_ana_sayfa.db.urunler.Add(entity);
                frm_ana_sayfa.db.SaveChanges();
                this.btn_kaydet_Click((object)null, (EventArgs)null);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (this.item == null)
            {
                int num = (int)MessageBox.Show("Lütfen Ürün Seçimi Yapınız!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                this.stok = new stok_giris()
                {
                    adet = double.Parse(this.txt_miktar.Text),
                    tutar = double.Parse(this.txt_tutar.Text.Replace("₺", "")),
                    urun = this.item,
                    urun_id = this.item.id,
                    fiyat = double.Parse(this.txt_fiyat.Text),
                    kdv = double.Parse(this.txt_kdv.Text)
                };
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_stok_drm_Click(object sender, EventArgs e)
        {
        }

        private void txt_kdv_TextChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(this.txt_kdv.Text.Length == 0 ? "0" : this.txt_kdv.Text);
            double num2 = double.Parse(this.txt_miktar.Text.Length == 0 ? "1" : this.txt_miktar.Text);
            double num3 = double.Parse(this.txt_fiyat.Text.Length == 0 ? "0" : this.txt_fiyat.Text);
            this.txt_tutar.Text = ((num3 + num3 * (num1 / 100.0)) * num2).ToString() + " ₺";
        }

        private void txt_kdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || (sender as TextBox).Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }
    }
}
