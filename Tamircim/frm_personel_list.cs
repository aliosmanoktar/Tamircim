using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tamircim
{
    public partial class frm_personel_list : Form
    {
        public personel select_personel;
        private bool select;

        public frm_personel_list()
        {
            InitializeComponent();
        }

        public frm_personel_list(bool select)
        {
            this.select = select;
            InitializeComponent();
        }

        private void frm_personel_list_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            cmb_secenekler.Items.AddRange(new string[] { "Ad", "Telefon", "Adres", "Bolum" });
            string[] column = { "Ad", "Telefon", "Adres", "Bolum", "Ucret" };
            list_personel.ColumnCount = column.Length;
            for (int i = 0; i < list_personel.ColumnCount; i++)
                list_personel.Columns[i].Name = column[i];
            personelList(frm_ana_sayfa.db.personels.ToList());

        }

        void personelList(List<personel> personels)
        {
            personels = personels.OrderByDescending(p => p.id).ToList();
            list_personel.Rows.Clear();
            foreach(personel item in personels)
            {
                int index = list_personel.Rows.Add();
                DataGridViewRow row = list_personel.Rows[index];
                row.Cells[0].Value = item.ad;
                row.Cells[1].Value = item.telefon;
                row.Cells[2].Value = item.adres;
                row.Cells[3].Value = item.bolum;
                row.Cells[4].Value = item.ucret+" ₺";
                row.Tag = item;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            frm_personel_ekle frm = new frm_personel_ekle();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                personelList(frm_ana_sayfa.db.personels.ToList());
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if(list_personel.SelectedRows.Count>0 && list_personel.SelectedRows[0].Tag != null)
            {
                frm_personel_ekle frm = new frm_personel_ekle((personel)list_personel.SelectedRows[0].Tag);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    personelList(frm_ana_sayfa.db.personels.ToList());
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (list_personel.SelectedRows.Count > 0 && list_personel.SelectedRows[0].Tag != null)
            {
                DialogResult ds = MessageBox.Show("Seçili personeli silmek istediğinizden eminmisiniz?\nBu işlem personel ile ilgili işlemleride silecektir!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds == DialogResult.Yes)
                {
                    frm_ana_sayfa.db.personels.Remove(list_personel.SelectedRows[0].Tag as personel);
                    frm_ana_sayfa.db.SaveChanges();
                    personelList(frm_ana_sayfa.db.personels.ToList());
                }
            }
        }

        private void list_personel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(list_personel.SelectedRows.Count>0 && list_personel.SelectedRows[0].Tag != null)
            {
                select_personel = list_personel.SelectedRows[0].Tag as personel;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (grp_arama.Visible)
                return;
            cmb_secenekler.SelectedIndex = 0;
            txt_aranan.Text = "";
            grp_arama.Visible = true;
            list_personel.Height -= grp_arama.Height;
            list_personel.Location = new System.Drawing.Point(list_personel.Location.X, list_personel.Location.Y + grp_arama.Height + 5);
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            grp_arama.Visible = false;
            list_personel.Height += grp_arama.Height;
            list_personel.Location = new System.Drawing.Point(list_personel.Location.X, list_personel.Location.Y - grp_arama.Height - 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_secenekler.SelectedIndex == 0)
                personelList(frm_ana_sayfa.db.personels.Where(p=>p.ad.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
            else if(cmb_secenekler.SelectedIndex==1)
                personelList(frm_ana_sayfa.db.personels.Where(p => p.telefon.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
            else if(cmb_secenekler.SelectedIndex==2)
                personelList(frm_ana_sayfa.db.personels.Where(p => p.adres.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
            else if(cmb_secenekler.SelectedIndex==3)
                personelList(frm_ana_sayfa.db.personels.Where(p => p.bolum.ToLower().Contains(txt_aranan.Text.ToLower())).ToList());
        }

        private void btn_islem_listele_Click(object sender, EventArgs e)
        {
            if(list_personel.SelectedRows.Count>0 && list_personel.SelectedRows[0].Tag != null)
            {
                personel item = list_personel.SelectedRows[0].Tag as personel;
                new frm_personel_islemleri(item).ShowDialog();
            }
            else
            {
                MessageBox.Show("Personel İşlemlerini listeleyebilmek için personel seçmeniz gerekmektedir!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}