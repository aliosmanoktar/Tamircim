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
    public partial class frm_personel_islemleri : Form
    {
        personel item=null;

        public frm_personel_islemleri()
        {
            InitializeComponent();
        }

        public frm_personel_islemleri(personel personel)
        {
            item = personel;
            InitializeComponent();
        }

        private void frm_personel_islemleri_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            if (item != null) {
                list_personel_islem.Location = new Point(list_personel_islem.Location.X, list_personel_islem.Location.Y - btn_ekle.Height);
                btn_duzenle.Visible = btn_ekle.Visible = btn_sil.Visible = false;
            }
            string[] column = { "Personel", "Tarih", "Açıklama", "Ücret" };
            list_personel_islem.ColumnCount = column.Length;
            for (int i = 0; i < list_personel_islem.ColumnCount; i++)
                list_personel_islem.Columns[i].Name = column[i];
            if(item==null)
                PersonelIslemListele(frm_ana_sayfa.db.personel_islemleri.ToList());
            else PersonelIslemListele(frm_ana_sayfa.db.personel_islemleri.Where(p=>p.personel_id==item.id).ToList());
        }

        private void PersonelIslemListele(List<personel_islemleri> islemler)
        {
            islemler = islemler.OrderByDescending(i => i.id).ToList();
            list_personel_islem.Rows.Clear();
            foreach(personel_islemleri item in islemler)
            {
                int index = list_personel_islem.Rows.Add();
                DataGridViewRow row = list_personel_islem.Rows[index];
                personel personel = frm_ana_sayfa.db.personels.FirstOrDefault(p => p.id == item.personel_id);
                row.Cells[0].Value = personel.ad;
                row.Cells[1].Value = item.tarih;
                row.Cells[2].Value = item.aciklama;
                row.Cells[3].Value = item.ucret+" ₺";
                row.Tag = item;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            frm_personel_islem_ekle frm = new frm_personel_islem_ekle();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                PersonelIslemListele(frm_ana_sayfa.db.personel_islemleri.ToList());
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if(list_personel_islem.SelectedRows.Count>0 && list_personel_islem.SelectedRows[0].Tag != null)
            {

                frm_personel_islem_ekle frm = new frm_personel_islem_ekle((personel_islemleri)list_personel_islem.SelectedRows[0].Tag);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    PersonelIslemListele(frm_ana_sayfa.db.personel_islemleri.ToList());
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if(list_personel_islem.SelectedRows.Count>0 && list_personel_islem.SelectedRows[0].Tag != null)
            {
                DialogResult ds = MessageBox.Show("Seçili personel işlemini silmek istediğinizden eminmisiniz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds == DialogResult.Yes)
                {
                    personel_islemleri islem = list_personel_islem.SelectedRows[0].Tag as personel_islemleri;
                    frm_ana_sayfa.db.personel_islemleri.Remove(frm_ana_sayfa.db.personel_islemleri.FirstOrDefault(p => p.id == islem.id));
                    frm_ana_sayfa.db.SaveChanges();
                    PersonelIslemListele(frm_ana_sayfa.db.personel_islemleri.ToList());
                }
            }
        }
    }
}