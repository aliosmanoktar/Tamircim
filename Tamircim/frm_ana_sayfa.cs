using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Text;

namespace Tamircim
{
    public partial class frm_ana_sayfa : Form
    {
        public static veritabani db { set; get; }
        firma item=null;
        public frm_ana_sayfa()
        {
            InitializeComponent();
        }
        public frm_ana_sayfa(firma firma)
        {
            InitializeComponent();
            item = firma;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
            db = new veritabani();
            /*if (!checkLisans())
            {
                MessageBox.Show("Geçersiz lisans tespit edildi.\nLisans almak için http://www.catsbilisim.net/ üzerinden bizimle iletişime geçiniz");
                Environment.Exit(0);
            }*/
            /*db.arac_ariza.ToList();
            db.arizalar.ToList();
            db.cari_islemeler.ToList();
            db.firma.ToList();
            db.musteris.ToList();
            db.odemeler.ToList();
            db.personels.ToList();
            db.personel_islemleri.ToList();
            db.servis.ToList();
            db.stok_girisleri.ToList();
            db.tamirler.ToList();
            db.tedarik_islemleri.ToList();
            db.urunler.ToList();
            db.yedek_parca.ToList();*/
            if (item == null)
                EkranAyarla();
            else
            {
                db.firma.Add(item);
                db.SaveChanges();
                Environment.Exit(0);
            }            
        }
        private void EkranAyarla()
        {
            string[] columns = new string[] { "Ünvan", "Plaka", "Model", "Telefon", "Şasi No", "Motor No" };
            list_cari.ColumnCount = columns.Length;
            list_cari.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            list_cari.BackgroundColor = Color.White;
            for (int i = 0; i < list_cari.ColumnCount; i++)
                list_cari.Columns[i].Name = columns[i];
            columns = new string[] { "No", "Tarih", "Saat", "Km", "Getiren" };
            list_servis.ColumnCount = columns.Length;
            for (int i = 0; i < list_servis.ColumnCount; i++)
                list_servis.Columns[i].Name = columns[i];
            columns = new string[] { "Kodu", "Değişen Parça", "Birim", "KDV", "Miktar", "Fiyat", "Tutar" };
            list_yedek_parca.ColumnCount = columns.Length;
            for (int i = 0; i < list_yedek_parca.ColumnCount; i++)
                list_yedek_parca.Columns[i].Name = columns[i];
            list_iscilik.ColumnCount = columns.Length;
            for (int i = 0; i < list_yedek_parca.ColumnCount; i++)
                list_iscilik.Columns[i].Name = columns[i];
            columns = new string[] { "ariza" };
            list_arizalar.ColumnCount = columns.Length;
            for (int i = 0; i < list_arizalar.ColumnCount; i++)
                list_arizalar.Columns[i].Name = columns[i];
            list_servis.Resize += List_Resize;
            List_Resize(list_servis, null);
            list_yedek_parca_Resize(list_yedek_parca, null);
            list_yedek_parca_Resize(list_iscilik, null);
            list_cari.MultiSelect = false;
            list_servis.MultiSelect = false;
            list_yedek_parca.MultiSelect = false;
            cari_listele(db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci).ToList());
        }
        private void cari_listele(List<musteri> musteris)
        {
            musteris= musteris.OrderByDescending(x => x.id).ToList();
            list_cari.Rows.Clear();
            foreach (musteri item in musteris)
            {
                int index = list_cari.Rows.Add();
                DataGridViewRow row = list_cari.Rows[index];
                row.Tag = item;
                row.Cells[0].Value = item.ad;
                row.Cells[1].Value = item.plaka;
                row.Cells[2].Value = item.model;
                row.Cells[3].Value = item.tel;
                row.Cells[4].Value = item.sasi;
                row.Cells[5].Value = item.motor;
            }
            if(list_cari.SelectedRows.Count>0)
                list_cari.SelectedRows[0].Selected = false;
        }
        private void List_Resize(object sender,EventArgs e)
        {
            DataGridView list = (DataGridView)sender;
            int size = (list.Width / list.Columns.Count) - 1;
            for (int i = 0; i < list.Columns.Count; i++)
                list.Columns[i].Width = size;
        }
        private void btn_musteri_ekle_Click(object sender, EventArgs e)
        {
            frm_musteri_ekle frm = new frm_musteri_ekle(musteri_type.musteri);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                cari_listele(db.musteris.Where(m => m.cari != musteri_type.cari && m.cari!=musteri_type.toptanci).ToList());
            }
        }
        private void list_yedek_parca_Resize(object sender, EventArgs e)
        {
            DataGridView gr = (DataGridView)sender;
            int size = gr.Width / (gr.Columns.Count + 4);
            for (int i = 0; i < gr.Columns.Count; i++)
                if (i == 1)
                    gr.Columns[i].Width = size * 5;
                else
                    gr.Columns[i].Width = size;
        }
        private void btn_yedek_parca_ekle_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null)
            {
                int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                frm_parca_ekle frm = new frm_parca_ekle(id,iscilik_turu.yedek_parca);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK) {
                    List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                    foreach (tamir item in tamir)
                    {
                        item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                        if (item.yedek_parca != null)
                        {
                            int urun_id = item.yedek_parca.urun_id;
                            item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                        }
                    }
                    tamir_listele(tamir);
                }
            }
            else
            {
                MessageBox.Show("Yedek parça eklemek için öncelikli olarak servis seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tamir_listele(List<tamir> list)
        {
            list = list.OrderByDescending(t => t.id).ToList();
            list_iscilik.Rows.Clear();
            list_yedek_parca.Rows.Clear();
            foreach (tamir item in list)
            {
                if (item.yedek_parca != null)
                {
                    int index = item.iscilik==iscilik_turu.yedek_parca ? list_yedek_parca.Rows.Add(): list_iscilik.Rows.Add();
                    DataGridViewRow row = item.iscilik == iscilik_turu.yedek_parca ? list_yedek_parca.Rows[index] : list_iscilik.Rows[index];
                    row.Cells[0].Value = item.yedek_parca.urun.kodu;
                    row.Cells[1].Value = item.yedek_parca.urun.adi;
                    row.Cells[2].Value = item.yedek_parca.urun.birim;
                    row.Cells[3].Value = "% "+item.yedek_parca.kdv + "";
                    row.Cells[4].Value = item.yedek_parca.adet + "";
                    row.Cells[5].Value = item.yedek_parca.fiyat;
                    row.Cells[6].Value = item.yedek_parca.tutar + "";
                    row.Tag = item.yedek_parca;
                }
            }
        }
        private void btn_servis_ekle_Click(object sender, EventArgs e)
        {
            if(list_cari.SelectedRows.Count>0)
            {
                frm_servis_ekle frm = new frm_servis_ekle((musteri)list_cari.SelectedRows[0].Tag);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    int musteri_id = ((musteri)list_cari.SelectedRows[0].Tag).id;
                    servis_listele(db.servis.Where(i => i.musteri_id == musteri_id).ToList());
                }
            }
            else
            {
                MessageBox.Show("Servis işlemi eklemek için öncelikli olarak müşteri seçmeniz gerekmektedir.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btn_servis_duzenle_Click(object sender, EventArgs e)
        {
           
            if(list_servis.SelectedRows.Count>0 && list_servis.SelectedRows[0].Tag!=null)
            {
                frm_servis_ekle frm = new frm_servis_ekle((servis)list_servis.SelectedRows[0].Tag);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    int musteri_id = ((musteri)list_cari.SelectedRows[0].Tag).id;
                    servis_listele(db.servis.Where(i => i.musteri_id == musteri_id).ToList());
                }
            }
            else
            {
                MessageBox.Show("Servis işlemini düzenlemek için öncelikli olarak servis işlemi seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void list_cari_SelectionChanged(object sender, EventArgs e)
        {
            if (list_cari.SelectedRows.Count > 0 && null!= list_cari.SelectedRows[0].Tag)
            {
                int musteri_id = ((musteri)list_cari.SelectedRows[0].Tag).id;
                servis_listele(db.servis.Where(i => i.musteri_id == musteri_id).ToList());
            }
        }
        private void servis_listele(List<servis> servis)
        {
            list_servis.Rows.Clear();
            list_yedek_parca.Rows.Clear();
            txt_ariza_arka_duzen.Text = txt_ariza_elektrik_sistemi.Text = txt_ariza_frenler.Text = txt_ariza_genel_bakim.Text = txt_ariza_karosor.Text = txt_ariza_klima.Text = txt_ariza_motor.Text = txt_ariza_on_duzen.Text = txt_ariza_sanziman.Text = "";
            foreach (servis item in servis){
                int index = list_servis.Rows.Add();
                DataGridViewRow row = list_servis.Rows[index];
                row.Tag = item;
                row.Cells[0].Value = item.id;
                row.Cells[1].Value = item.tarih;
                row.Cells[2].Value = item.saat;
                row.Cells[3].Value = item.km;
                row.Cells[4].Value = item.getiren;
            }
            if(list_servis.SelectedRows.Count>0)
                list_servis.SelectedRows[0].Selected = false;
        }
        private void btn_bakim_kaydet_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null) {
                if (txt_ariza_genel_bakim.Tag == null)
                {
                    arac_ariza item = new arac_ariza()
                    {
                        servis_id = ((servis)list_servis.SelectedRows[0].Tag).id,
                        arka_duzen = txt_ariza_arka_duzen.Text,
                        elektrik = txt_ariza_elektrik_sistemi.Text,
                        frenler = txt_ariza_frenler.Text,
                        genel_bakim = txt_ariza_genel_bakim.Text,
                        karoser = txt_ariza_karosor.Text,
                        klima = txt_ariza_klima.Text,
                        motor = txt_ariza_motor.Text,
                        on_duzen = txt_ariza_on_duzen.Text,
                        sanziman = txt_ariza_sanziman.Text,
                        not = txt_ariza_not.Text,
                        diger = txt_ariza_dgr.Text
                    };
                    db.arac_ariza.Add(item);
                    db.SaveChanges();
                    txt_ariza_genel_bakim.Tag = item;
                }
                else
                {
                    int id = ((arac_ariza)txt_ariza_genel_bakim.Tag).id;
                    arac_ariza item = db.arac_ariza.FirstOrDefault(a => a.id == id);
                    item.arka_duzen = txt_ariza_arka_duzen.Text;
                    item.elektrik = txt_ariza_elektrik_sistemi.Text;
                    item.frenler = txt_ariza_frenler.Text;
                    item.genel_bakim = txt_ariza_genel_bakim.Text;
                    item.karoser = txt_ariza_karosor.Text;
                    item.klima = txt_ariza_klima.Text;
                    item.motor = txt_ariza_motor.Text;
                    item.on_duzen = txt_ariza_on_duzen.Text;
                    item.sanziman = txt_ariza_sanziman.Text;
                    item.not = txt_ariza_not.Text;
                    item.diger = txt_ariza_dgr.Text;
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Arıza işlemi eklemek için öncelikli olarak servis seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void arizaListele(List<arizalar> ariza)
        {
            ariza = ariza.OrderByDescending(a => a.id).ToList();
            list_arizalar.Rows.Clear();
            foreach(arizalar item in ariza)
            {
                int index = list_arizalar.Rows.Add();
                DataGridViewRow row = list_arizalar.Rows[index];
                row.Cells[0].Value = item.ariza;
                row.Tag = item;
            }
        }
        private void list_servis_SelectionChanged(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null) {
                int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                arac_ariza arac_Ariza = db.arac_ariza.FirstOrDefault(a => a.servis_id == id);
                txt_ariza_genel_bakim.Tag = arac_Ariza;
                list_yedek_parca.Rows.Clear();
                if (arac_Ariza != null)
                {
                    txt_ariza_arka_duzen.Text = arac_Ariza.arka_duzen;
                    txt_ariza_elektrik_sistemi.Text = arac_Ariza.elektrik;
                    txt_ariza_frenler.Text = arac_Ariza.frenler;
                    txt_ariza_genel_bakim.Text = arac_Ariza.genel_bakim;
                    txt_ariza_karosor.Text = arac_Ariza.karoser;
                    txt_ariza_klima.Text = arac_Ariza.klima;
                    txt_ariza_motor.Text = arac_Ariza.motor;
                    txt_ariza_on_duzen.Text = arac_Ariza.on_duzen;
                    txt_ariza_sanziman.Text = arac_Ariza.sanziman;
                    txt_ariza_not.Text = arac_Ariza.not;
                    txt_ariza_dgr.Text = arac_Ariza.diger;
                }
                else
                {
                    txt_ariza_arka_duzen.Text = txt_ariza_elektrik_sistemi.Text = txt_ariza_frenler.Text = txt_ariza_genel_bakim.Text = txt_ariza_karosor.Text = txt_ariza_klima.Text = txt_ariza_motor.Text = txt_ariza_on_duzen.Text = txt_ariza_sanziman.Text = "";
                }
                arizaListele(db.arizalar.Where(a => a.servis_id == id).ToList());
                List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                foreach (tamir item in tamir)
                {
                    item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                    if (item.yedek_parca != null)
                    {
                        int urun_id = item.yedek_parca.urun_id;
                        item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                    }
                }
                tamir_listele(tamir);
            }
        }
        private void btn_yedek_parca_duzenle_Click(object sender, EventArgs e)
        {
            if(list_yedek_parca.SelectedRows.Count>0 && list_yedek_parca.SelectedRows[0].Tag!=null)
            {
                yedek_parca ydparca = (yedek_parca)list_yedek_parca.SelectedRows[0].Tag;
                frm_parca_ekle frm = new frm_parca_ekle(ydparca,iscilik_turu.yedek_parca);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                    List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                    foreach (tamir item in tamir)
                    {
                        item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                        if (item.yedek_parca != null)
                        {
                            int urun_id = item.yedek_parca.urun_id;
                            item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                        }
                    }
                    tamir_listele(tamir);
                }
            }
            else
            {
                MessageBox.Show("Yedek parça düzenlemek için öncelikli olarak yedek parçayı seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_musteri_duzelt_Click(object sender, EventArgs e)
        {
            if(list_cari.SelectedRows.Count>0 && list_cari.SelectedRows[0].Tag != null)
            {
                musteri item = list_cari.SelectedRows[0].Tag as musteri;
                frm_musteri_ekle frm = new frm_musteri_ekle(item);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    cari_listele(db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci).ToList());
                }
            }
            else
            {
                MessageBox.Show("Müşteriyi düzenlemek için öncelikli olarak müşteri seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_iscilik_ekle_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null)
            {
                int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                frm_parca_ekle frm = new frm_parca_ekle(id, iscilik_turu.yapilan_iscilik);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                    foreach (tamir item in tamir)
                    {
                        item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                        if (item.yedek_parca != null)
                        {
                            int urun_id = item.yedek_parca.urun_id;
                            item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                        }
                    }
                    tamir_listele(tamir);
                }
            }
        }
        private void btn_iscilik_duzenle_Click(object sender, EventArgs e)
        {
            if (list_iscilik.SelectedRows.Count > 0 && list_iscilik.SelectedRows[0].Tag != null)
            {
                yedek_parca ydparca = (yedek_parca)list_iscilik.SelectedRows[0].Tag;
                frm_parca_ekle frm = new frm_parca_ekle(ydparca, iscilik_turu.yapilan_iscilik);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                    List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                    foreach (tamir item in tamir)
                    {
                        item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                        if (item.yedek_parca != null)
                        {
                            int urun_id = item.yedek_parca.urun_id;
                            item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                        }
                    }
                    tamir_listele(tamir);
                }
            }
        }
        private void btn_servis_toplam_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null)
            {
                int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                foreach (tamir item in tamir)
                {
                    item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                    if (item.yedek_parca != null)
                    {
                        int urun_id = item.yedek_parca.urun_id;
                        item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                    }
                }
                new frm_servis_toplam(tamir,id).ShowDialog();
            }
            else
            {
                MessageBox.Show("Servis işlemininin toplamını görmek için öncelikli olarak servis işlemi seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_cari_sil_Click(object sender, EventArgs e)
        {
            if (list_cari.SelectedRows.Count > 0 && list_cari.SelectedRows[0].Tag != null)
            {
                DialogResult msg = MessageBox.Show("Seçili müşteriyi silmek istediğinizden eminmisiniz? \nBu işlem müşteri ve ona bağlı iş emirlerini silecektir!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    int musteri_id = ((musteri)list_cari.SelectedRows[0].Tag).id;
                    List <servis> servis = db.servis.Where(i => i.musteri_id == musteri_id).ToList();
                    foreach (servis item in servis)
                    {
                        arac_ariza ariza = db.arac_ariza.FirstOrDefault(a => a.servis_id == item.id);
                        if(ariza!=null)
                        db.arac_ariza.Remove(ariza);
                        db.tamirler.RemoveRange(db.tamirler.Where(t => t.servis_id == item.id).ToList());
                    }
                    db.servis.RemoveRange(servis);
                    musteri musteri = (musteri)list_cari.SelectedRows[0].Tag;
                    if (musteri.cari == musteri_type.cari)
                        db.musteris.Remove(musteri);
                    else
                    {
                        musteri.cari = musteri_type.cari;
                       musteri.model = musteri.plaka = musteri.plaka = musteri.sasi = musteri.motor = "";
                    }
                    db.SaveChanges();
                    list_servis.Rows.Clear();
                    list_yedek_parca.Rows.Clear();
                    list_iscilik.Rows.Clear();
                    txt_ariza_arka_duzen.Text = txt_ariza_elektrik_sistemi.Text = txt_ariza_frenler.Text = txt_ariza_genel_bakim.Text = txt_ariza_karosor.Text = txt_ariza_klima.Text = txt_ariza_motor.Text = txt_ariza_on_duzen.Text = txt_ariza_sanziman.Text = "";
                    cari_listele(db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci).ToList());
                }
            }
            else
            {
                MessageBox.Show("Müşteriyi düzenlemek için öncelikli olarak müşteri seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_servis_sil_Click(object sender, EventArgs e)
        {
            if(list_servis.SelectedRows.Count>0 && list_servis.SelectedRows[0].Tag != null)
            {
                DialogResult msg = MessageBox.Show("Seçili servis işlemini silmek istediğizden eminmisiniz?\nServis işlemine bağlı olan yedek parça ve işçilik işlemleride silinecektir!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    servis servis = list_servis.SelectedRows[0].Tag as servis;
                    arac_ariza ariza = db.arac_ariza.FirstOrDefault(a => a.servis_id == servis.id);
                    if (ariza != null)
                        db.arac_ariza.Remove(ariza);
                    db.tamirler.RemoveRange(db.tamirler.Where(t => t.servis_id == servis.id).ToList());
                    db.servis.Remove(servis);
                    db.SaveChanges();
                    int musteri_id = ((musteri)list_cari.SelectedRows[0].Tag).id;
                    servis_listele(db.servis.Where(i => i.musteri_id == musteri_id).ToList());
                }
            }
            else
            {
                MessageBox.Show("Servis işlemini silmek için öncelikli olarak servis işlemi seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_servis_araclari_Click(object sender, EventArgs e)
        {
            new frm_serviste_bulunan_araclar().ShowDialog();
        }
        private void cariKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_list_cari().ShowDialog();
        }
        private void cariİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_cari_islem().ShowDialog();
        }
        private void stokKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void personelKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_personel_list().ShowDialog();
        }
        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_personel_islemleri().ShowDialog();
        }
        private void btn_musteri_cogalt_Click(object sender, EventArgs e)
        {
            if(list_cari.SelectedRows.Count>0 && list_cari.SelectedRows[0].Tag != null)
            {
                musteri item = list_cari.SelectedRows[0].Tag as musteri;
                item.cari = musteri_type.musteri;
                item.motor = item.model = item.plaka = item.sasi = "";
                db.musteris.Add(item);
                db.SaveChanges();
                cari_listele(db.musteris.Where(m => m.cari != musteri_type.cari && m.cari != musteri_type.toptanci).ToList());
            }
        }
        private void btn_ydk_prc_sil_Click(object sender, EventArgs e)
        {
            if(list_yedek_parca.SelectedRows.Count>0 && list_yedek_parca.SelectedRows[0].Tag != null)
            {
                DialogResult ds = MessageBox.Show("Seçili yedek parca işlemini silmek istediğinizden eminmisiniz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds != DialogResult.Yes)
                    return;
                int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                yedek_parca temp = list_yedek_parca.SelectedRows[0].Tag as yedek_parca;
                db.yedek_parca.Remove(temp);
                db.SaveChanges();
                List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                foreach (tamir item in tamir)
                {
                    item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                    if (item.yedek_parca != null)
                    {
                        int urun_id = item.yedek_parca.urun_id;
                        item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                    }
                }
                tamir_listele(tamir);
            }
            else
            {
                MessageBox.Show("Yedek parça silmek için öncelikli olarak yedek parça seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_iscilik_sil_Click(object sender, EventArgs e)
        {
            if (list_iscilik.SelectedRows.Count > 0 && list_iscilik.SelectedRows[0].Tag != null)
            {
                DialogResult ds = MessageBox.Show("Seçili işçilik işlemini silmek istediğinizden eminmisiniz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ds != DialogResult.Yes)
                    return;
                int id = ((servis)list_servis.SelectedRows[0].Tag).id;
                yedek_parca temp = list_iscilik.SelectedRows[0].Tag as yedek_parca;
                db.yedek_parca.Remove(temp);
                db.SaveChanges();
                List<tamir> tamir = db.tamirler.Where(t => t.servis_id == id).ToList();
                foreach (tamir item in tamir)
                {
                    item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                    if (item.yedek_parca != null)
                    {
                        int urun_id = item.yedek_parca.urun_id;
                        item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                    }
                }
                tamir_listele(tamir);
            }
        }
        private void btn_servis_yazdir_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null)
            {
                frm_servis_yazdir frm = new frm_servis_yazdir();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Abort)
                {
                    servis servis = ((servis)list_servis.SelectedRows[0].Tag);
                    arac_ariza arac_Ariza = db.arac_ariza.FirstOrDefault(a => a.servis_id == servis.id);
                    List<tamir> tamir = db.tamirler.Where(t => t.servis_id == servis.id).ToList();
                    foreach (tamir item in tamir)
                    {
                        item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                        if (item.yedek_parca != null)
                        {
                            int urun_id = item.yedek_parca.urun_id;
                            item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                        }
                    }
                    musteri musteri = list_cari.SelectedRows[0].Tag as musteri;
                    List<arizalar> arizalar = db.arizalar.Where(a => a.servis_id == servis.id).ToList();
                    print.printISEmriAc(arac_Ariza, musteri, servis, arizalar);
                }
                else if (frm.DialogResult == DialogResult.Ignore)
                {
                    musteri musteri = list_cari.SelectedRows[0].Tag as musteri;
                    servis servis = ((servis)list_servis.SelectedRows[0].Tag);
                    List<tamir> tamir = db.tamirler.Where(t => t.servis_id == servis.id).ToList();
                    foreach (tamir item in tamir)
                    {
                        item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                        if (item.yedek_parca != null)
                        {
                            int urun_id = item.yedek_parca.urun_id;
                            item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                        }
                    }
                    print.PrintSonuc(musteri, servis, tamir);
                }
            }
            else
            {
                MessageBox.Show("Servis işlemini yazdırmak için öncelikli olarak servis işlemi seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ariza_ekle_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null)
            {
                int servis_id = ((servis)(list_servis.SelectedRows[0].Tag)).id;
                frm_ariza_ekle frm = new frm_ariza_ekle(servis_id);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    arizaListele(db.arizalar.Where(a => a.servis_id == servis_id).ToList());
                }
            }
            else
            {
                MessageBox.Show("Arıza işlemi eklemek için öncelikli olarak servis seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_ariza_duzenle_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null && list_arizalar.SelectedRows.Count>0 && list_arizalar.SelectedRows[0].Tag!=null)
            {
                arizalar item = ((arizalar)(list_arizalar.SelectedRows[0].Tag));
                frm_ariza_ekle frm = new frm_ariza_ekle(item);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    arizaListele(db.arizalar.Where(a => a.servis_id == item.servis_id).ToList());
                }
            }
            else
            {
                MessageBox.Show("Arıza işlemi düzenlemek için öncelikli olarak arıza seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cariKartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            print.PrintCariKart(db.musteris.Where(m => m.cari != musteri_type.musteri).ToList());
        }
        private void cariHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_cari_ekstre_yazdir().ShowDialog();
        }
        private void btn_ariza_sil_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null && list_arizalar.SelectedRows.Count > 0 && list_arizalar.SelectedRows[0].Tag != null)
            {
                DialogResult dt = MessageBox.Show("Seçili Arıza işlemini silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dt == DialogResult.Yes)
                {
                    arizalar item = ((arizalar)(list_arizalar.SelectedRows[0].Tag));
                    db.arizalar.Remove(db.arizalar.FirstOrDefault(a => a.id == item.id));
                    db.SaveChanges();
                    arizaListele(db.arizalar.Where(a => a.servis_id == item.servis_id).ToList());
                }
            }
            else
            {
                MessageBox.Show("Arıza işlemi silmek için öncelikli olarak arıza seçmeniz gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void müşteriKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(list_servis.SelectedRows.Count>0 && list_servis.SelectedRows[0].Tag != null)
            {
                servis servis = ((servis)list_servis.SelectedRows[0].Tag);
                arac_ariza arac_Ariza = db.arac_ariza.FirstOrDefault(a => a.servis_id == servis.id);
                List<tamir> tamir = db.tamirler.Where(t => t.servis_id == servis.id).ToList();
                foreach (tamir item in tamir)
                {
                    item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                    if (item.yedek_parca != null)
                    {
                        int urun_id = item.yedek_parca.urun_id;
                        item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                    }
                }
                musteri musteri = list_cari.SelectedRows[0].Tag as musteri;
                List<arizalar> arizalar = db.arizalar.Where(a => a.servis_id == servis.id).ToList();
                print.printISEmriAc(arac_Ariza, musteri, servis, arizalar);
            }
            else
            {
                MessageBox.Show("Müşteri kabul formunu yazdırmak için servis seçmeniz gerekmektedir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sonuçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list_servis.SelectedRows.Count > 0 && list_servis.SelectedRows[0].Tag != null)
            {
                musteri musteri = list_cari.SelectedRows[0].Tag as musteri;
                servis servis = ((servis)list_servis.SelectedRows[0].Tag);
                List<tamir> tamir = db.tamirler.Where(t => t.servis_id == servis.id).ToList();
                foreach (tamir item in tamir)
                {
                    item.yedek_parca = db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                    if (item.yedek_parca != null)
                    {
                        int urun_id = item.yedek_parca.urun_id;
                        item.yedek_parca.urun = db.urunler.FirstOrDefault(u => u.id == urun_id);
                    }
                }
                print.PrintSonuc(musteri, servis, tamir);
            }
            else
            {
                MessageBox.Show("Sonuç formunu yazdırmak için servis seçmeniz gerekmektedir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void açıkİşEmirleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print.PrintAcikIsemirleri(db.servis.Where(s => s.durum != islem_turu.kapali).ToList());
        }
        private void serviseGelenAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_servise_gelen_arac().ShowDialog();
        }
        private void personelİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_personel_ucret_tarih().ShowDialog();
        }
        private void personelKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print.PrintPersonelKart(db.personels.ToList());
        }
        private void toptancıKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_list_toptanci().ShowDialog();
        }
        private void stokDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_tedarik_rapor().ShowDialog();
        }
        private void stokKartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_stok_karti(false).ShowDialog();
        }
        private void stokGirişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_stok_giris().ShowDialog();
        }
        private string getRegedit()
        {
            string reg = @"Software\";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(reg, true);
            RegistryKey aKey = key.OpenSubKey("Tamircim");
            string value = aKey.GetValue("lisans").ToString();
            return value;
        }
        bool checkLisans()
        {
            string pc = sha256(CpuIdCheck() + MacVer() + SystemInformation.ComputerName);
            try
            {
                return pc.Equals(getRegedit());
            }
            catch
            {
                return false;
            }
        }
        static string sha256(string randomString)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
        private string CpuIdCheck()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }
        private string MacVer()
        {
            return
                 (
                 from nic in NetworkInterface.GetAllNetworkInterfaces()
                 where nic.OperationalStatus == OperationalStatus.Up
                 select nic.GetPhysicalAddress().ToString()
                 ).FirstOrDefault();
        }
        private void btn_arama_Click(object sender, EventArgs e)
        {
            frm_musteri_arama frm =new frm_musteri_arama();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                cari_listele(frm.musteriler);
        }

        private void pnl_ust_bar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}