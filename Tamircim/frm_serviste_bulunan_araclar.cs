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
    public partial class frm_serviste_bulunan_araclar : Form
    {
        public frm_serviste_bulunan_araclar()
        {
            InitializeComponent();
        }
        private void frm_serviste_bulunan_araclar_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            string[] column = { "İş Emri No", "Firma", "Plaka", "Model", "Telefon", "Ser. Gel. Tar." };
            list_servisteki_araclar.ColumnCount = column.Length ;
            for (int i = 0; i < column.Length; i++)
                list_servisteki_araclar.Columns[i].Name = column[i];
            foreach(servis item in frm_ana_sayfa.db.servis.ToList())
                Console.WriteLine(item.durum);
            List<servis> servis = frm_ana_sayfa.db.servis.Where(s => s.durum != islem_turu.kapali).ToList();
            islem_listele(servis);
        }
        private void islem_listele(List<servis> servis)
        {
            foreach(servis item in servis)
            {
                int index = list_servisteki_araclar.Rows.Add();
                DataGridViewRow row = list_servisteki_araclar.Rows[index];
                row.Cells[0].Value = item.id + "";
                musteri musteri = frm_ana_sayfa.db.musteris.FirstOrDefault(m => m.id == item.musteri_id);
                row.Cells[1].Value = musteri.ad;
                row.Cells[2].Value = musteri.plaka;
                row.Cells[3].Value = musteri.model;
                row.Cells[4].Value = musteri.tel;
                row.Cells[5].Value = item.tarih;
            }
        }
        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            print.PrintAcikIsemirleri(frm_ana_sayfa.db.servis.Where(s => s.durum != islem_turu.kapali).ToList());
        }
    }
}
