using System;
using System.Linq;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_personel_islem_ekle : Form
    {
        personel_islemleri islem;
        personel personel;
        public frm_personel_islem_ekle()
        {
            InitializeComponent();
        }
        public frm_personel_islem_ekle(personel_islemleri islem)
        {
            this.islem = islem;
            InitializeComponent();
        }


        private void btn_cari_listele_Click(object sender, EventArgs e)
        {
            frm_personel_list frm = new frm_personel_list(true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                personel = frm.select_personel;
                txt_ad.Text = personel.ad;
            }
        }

        private void frm_personel_islem_ekle_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (islem != null)
            {
                txt_aciklama.Text = islem.aciklama;
                txt_ucret.Text = islem.ucret + "";
                tarih.Value = DateTime.Parse(islem.tarih);
                personel = frm_ana_sayfa.db.personels.FirstOrDefault(p => p.id == islem.personel_id);
                txt_ad.Text = personel.ad;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (islem == null)
            {
                islem = new personel_islemleri()
                {
                    aciklama = txt_aciklama.Text,
                    personel_id = personel.id,
                    tarih = tarih.Text,
                    ucret = double.Parse(txt_ucret.Text)
                };
                frm_ana_sayfa.db.personel_islemleri.Add(islem);
                frm_ana_sayfa.db.SaveChanges();
            }else
            {
                islem = frm_ana_sayfa.db.personel_islemleri.FirstOrDefault(i => i.id == islem.id);
                islem.aciklama = txt_aciklama.Text;
                islem.personel_id = personel.id;
                islem.tarih = tarih.Text;
                islem.ucret = double.Parse(txt_ucret.Text);
                frm_ana_sayfa.db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
