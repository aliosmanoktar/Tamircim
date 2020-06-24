using FastReport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Tamircim
{
    class print
    {
        private static DataTable getFirmaTable()
        {
            firma firma = frm_ana_sayfa.db.firma.FirstOrDefault();
            DataTable sirket_bilgileri = new DataTable();
            sirket_bilgileri.TableName = "sirket_bilgileri";
            sirket_bilgileri.Columns.Add("sirket_adi", typeof(string));
            sirket_bilgileri.Columns.Add("telefon", typeof(string));
            sirket_bilgileri.Columns.Add("adres", typeof(string));
            sirket_bilgileri.Rows.Add(firma.name, firma.tel, firma.adres);
            return sirket_bilgileri;
        }
        private static string getPath()
        {
            return System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
        public static void printISEmriAc(arac_ariza ariza , musteri musteri,servis servis,List<arizalar> arz)
        {
            DataTable arizaTable = new DataTable();
            arizaTable.TableName = "arac_ariza";
            arizaTable.Columns.Add("gnl_bakim", typeof(string));
            arizaTable.Columns.Add("motor", typeof(string));
            arizaTable.Columns.Add("sanziman", typeof(string));
            arizaTable.Columns.Add("on_duzen", typeof(string));
            arizaTable.Columns.Add("arka_duzen", typeof(string));
            arizaTable.Columns.Add("frenler", typeof(string));
            arizaTable.Columns.Add("elektrik_sistemi", typeof(string));
            arizaTable.Columns.Add("klima", typeof(string));
            arizaTable.Columns.Add("karoser", typeof(string));
            arizaTable.Columns.Add("diger", typeof(string));
            arizaTable.Columns.Add("not", typeof(string));
            if(ariza!=null)
                arizaTable.Rows.Add(ariza.genel_bakim, ariza.motor, ariza.sanziman,ariza.on_duzen, ariza.arka_duzen, ariza.frenler, ariza.elektrik, ariza.klima, ariza.karoser, ariza.diger, ariza.not);
            else
                arizaTable.Rows.Add("", "","", "", "", "", "", "","", "");
            DataTable isEmri = new DataTable();
            isEmri.TableName = "is_emri";
            isEmri.Columns.Add("musteri_name", typeof(string));
            isEmri.Columns.Add("musteri_adres", typeof(string));
            isEmri.Columns.Add("musteri_tel", typeof(string));
            isEmri.Columns.Add("tarih", typeof(DateTime));
            isEmri.Columns.Add("arac_marka", typeof(string));
            isEmri.Columns.Add("sasi_no", typeof(string));
            isEmri.Columns.Add("arac_plaka", typeof(string));
            isEmri.Columns.Add("not", typeof(string));
            isEmri.Columns.Add("is_emri_id", typeof(int));
            isEmri.Columns.Add("emanet", typeof(string));
            isEmri.Columns.Add("km", typeof(string));
            isEmri.Rows.Add(musteri.ad, musteri.adres, musteri.tel, DateTime.Parse(servis.tarih), musteri.model, musteri.sasi, musteri.plaka, musteri.not, servis.id,servis.emanet,servis.km);
            DataTable arizalar = new DataTable();
            arizalar.TableName = "arizalar";
            arizalar.Columns.Add("name");
            foreach (arizalar item in arz)
                arizalar.Rows.Add(item.ariza);
            DataSet table = new DataSet();
            table.Tables.Add(isEmri);
            table.Tables.Add(arizaTable);
            table.Tables.Add(getFirmaTable());
            table.Tables.Add(arizalar);
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_musteri_kabul.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();
        }
        public static void PrintSonuc(musteri musteri,servis servis,List<tamir> tamirler)
        {
            DataTable arac = new DataTable();
            arac.TableName = "arac";
            arac.Columns.Add("plaka", typeof(string));
            arac.Columns.Add("model", typeof(string));
            arac.Columns.Add("sasi_no", typeof(string));
            arac.Columns.Add("motor_no", typeof(string));
            arac.Columns.Add("name", typeof(string));
            arac.Columns.Add("tel", typeof(string));
            arac.Columns.Add("tarih", typeof(string));
            arac.Columns.Add("km", typeof(string));
            arac.Columns.Add("emanetler", typeof(string));
            arac.Columns.Add("id", typeof(string));
            arac.Rows.Add(musteri.plaka, musteri.model, musteri.sasi, musteri.motor, musteri.ad, musteri.tel, servis.tarih, servis.km, servis.emanet,servis.id);
            DataTable iscilik = new DataTable();
            iscilik.TableName = "iscilik";
            iscilik.Columns.Add("name", typeof(string));
            iscilik.Columns.Add("kdv", typeof(string));
            iscilik.Columns.Add("miktar", typeof(string));
            iscilik.Columns.Add("b_fiyati", typeof(string));
            iscilik.Columns.Add("tutar", typeof(string));
            DataTable ydk_parca = new DataTable();
            ydk_parca.TableName = "ydk_parca";
            ydk_parca.Columns.Add("parca_adi", typeof(string));
            ydk_parca.Columns.Add("birim", typeof(string));
            ydk_parca.Columns.Add("kdv", typeof(string));
            ydk_parca.Columns.Add("miktar", typeof(string));
            ydk_parca.Columns.Add("b_fiyati", typeof(string));
            ydk_parca.Columns.Add("tutar", typeof(string));
            double ydk_parca_toplam=0,iscilik_toplam=0,kdv_toplam=0,genel_toplam=0;
            foreach(tamir item in tamirler)
            {
                if (item.yedek_parca != null)
                {
                    if (item.iscilik == iscilik_turu.yedek_parca)
                    {
                        ydk_parca.Rows.Add(item.yedek_parca.urun.adi, item.yedek_parca.urun.birim, "% "+item.yedek_parca.kdv, item.yedek_parca.adet, item.yedek_parca.fiyat + " ₺", (item.yedek_parca.adet * item.yedek_parca.fiyat) + " ₺");
                        ydk_parca_toplam += (item.yedek_parca.adet * item.yedek_parca.fiyat);
                    }else {
                        iscilik.Rows.Add(item.yedek_parca.urun.adi, "% "+item.yedek_parca.kdv, item.yedek_parca.adet, item.yedek_parca.fiyat+" ₺", (item.yedek_parca.adet * item.yedek_parca.fiyat) + " ₺");
                        iscilik_toplam += (item.yedek_parca.adet * item.yedek_parca.fiyat);
                    }
                    kdv_toplam += ((item.yedek_parca.kdv / 100) * item.yedek_parca.fiyat);
                    genel_toplam += item.yedek_parca.tutar;
                }
            }
            DataTable toplam = new DataTable();
            toplam.TableName = "toplam";
            toplam.Columns.Add("parca_toplam", typeof(string));
            toplam.Columns.Add("iscilik_toplam", typeof(string));
            toplam.Columns.Add("ara_toplam", typeof(string));
            toplam.Columns.Add("kdv", typeof(string));
            toplam.Columns.Add("gnl_toplam", typeof(string));
            toplam.Rows.Add(ydk_parca_toplam + " ₺", iscilik_toplam + " ₺", (iscilik_toplam + ydk_parca_toplam) + " ₺", kdv_toplam + " ₺", genel_toplam + " ₺");
            DataSet table = new DataSet();
            table.Tables.Add(toplam);
            table.Tables.Add(ydk_parca);
            table.Tables.Add(getFirmaTable());
            table.Tables.Add(arac);
            table.Tables.Add(iscilik);
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_sonuc.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();
        }
        public static void PrintCariKart(List<musteri> musteriler)
        {
            DataTable cariler = new DataTable();
            cariler.TableName = "cariler";
            cariler.Columns.Add("unvan", typeof(string));
            cariler.Columns.Add("adres", typeof(string));
            cariler.Columns.Add("telefon", typeof(string));
            foreach(musteri item in musteriler)
            {
                cariler.Rows.Add(item.ad, item.adres, item.tel);
            }
            DataSet table = new DataSet();
            table.Tables.Add(cariler);
            table.Tables.Add(getFirmaTable());
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_cariler.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();
        }
        public static void PrintCariEkstre(List<cari_islemleri> islemler,musteri cari,string tarih)
        {
            DataTable cari_islemleri = new DataTable();
            cari_islemleri.TableName = "cari_islemleri";
            cari_islemleri.Columns.Add("tarih", typeof(string));
            cari_islemleri.Columns.Add("islem_turu", typeof(string));
            cari_islemleri.Columns.Add("aciklama", typeof(string));
            cari_islemleri.Columns.Add("borc", typeof(string));
            cari_islemleri.Columns.Add("alacak", typeof(string));
            double alacak_toplam = 0, borc_toplam = 0;
            foreach(cari_islemleri item in islemler)
            {
                string islem = "";
                if (item.islem == cari_islem.cari_islem)
                    islem = "Cari İşlem";
                else if (item.islem == cari_islem.nakit)
                    islem = "Nakit İşlem";
                else if (item.islem == cari_islem.servis)
                    islem = "Servis";
                cari_islemleri.Rows.Add(item.tarih, islem, item.aciklama, item.borc + " ₺", item.alacak + " ₺");
                alacak_toplam += item.alacak;
                borc_toplam += item.borc;
            }
            DataTable cari_Table = new DataTable();
            cari_Table.TableName = "cari";
            cari_Table.Columns.Add("name", typeof(string));
            cari_Table.Columns.Add("tarih", typeof(string));
            cari_Table.Columns.Add("alacak_toplam", typeof(string));
            cari_Table.Columns.Add("borc_toplam", typeof(string));
            cari_Table.Rows.Add(cari.ad, tarih, alacak_toplam + " ₺", borc_toplam + " ₺");
            DataSet table = new DataSet();
            table.Tables.Add(cari_islemleri);
            table.Tables.Add(cari_Table);
            table.Tables.Add(getFirmaTable());
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_cari_ekstre.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();
        }
        public static void PrintCariEkstre(List<cari_islemleri> islemler,string tarih)
        {
            DataTable cari_islemleri = new DataTable();
            cari_islemleri.TableName = "cari_islemleri";
            cari_islemleri.Columns.Add("tarih", typeof(string));
            cari_islemleri.Columns.Add("islem_turu", typeof(string));
            cari_islemleri.Columns.Add("aciklama", typeof(string));
            cari_islemleri.Columns.Add("borc", typeof(string));
            cari_islemleri.Columns.Add("alacak", typeof(string));
            cari_islemleri.Columns.Add("name", typeof(string));
            double alacak_toplam = 0, borc_toplam = 0;
            foreach (cari_islemleri item in islemler)
            {
                string islem = "";
                if (item.islem == cari_islem.cari_islem)
                    islem = "Cari İşlem";
                else if (item.islem == cari_islem.nakit)
                    islem = "Nakit";
                else if (item.islem == cari_islem.servis)
                    islem = "Servis";
                string name = frm_ana_sayfa.db.musteris.FirstOrDefault(m => m.id == item.musteri_id).ad;
                cari_islemleri.Rows.Add(item.tarih, islem, item.aciklama, item.borc + " ₺", item.alacak + " ₺",name);
                alacak_toplam += item.alacak;
                borc_toplam += item.borc;
            }
            DataTable cari_Table = new DataTable();
            cari_Table.TableName = "cari";
            cari_Table.Columns.Add("tarih", typeof(string));
            cari_Table.Columns.Add("alacak_toplam", typeof(string));
            cari_Table.Columns.Add("borc_toplam", typeof(string));
            cari_Table.Rows.Add( tarih, alacak_toplam + " ₺", borc_toplam + " ₺");
            DataSet table = new DataSet();
            table.Tables.Add(cari_islemleri);
            table.Tables.Add(cari_Table);
            table.Tables.Add(getFirmaTable());
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_cari_ekstre_toplu.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();
        }
        public static void PrintAcikIsemirleri(List<servis> servisler)
        {
            DataTable is_emri = new DataTable();
            is_emri.TableName = "is_emri";
            is_emri.Columns.Add("is_emri_no", typeof(string));
            is_emri.Columns.Add("arac_plaka", typeof(string));
            is_emri.Columns.Add("tarih", typeof(string));
            is_emri.Columns.Add("tutar", typeof(string));
            is_emri.Columns.Add("name", typeof(string));
            double toplam = 0;
            foreach(servis item in servisler)
            {
                musteri musteri = frm_ana_sayfa.db.musteris.FirstOrDefault(m => m.id == item.musteri_id);
                double temp = getToplam(item.id);
                toplam += temp;
                is_emri.Rows.Add(item.id, musteri.plaka, item.tarih, temp + " ₺", musteri.ad);
            }
            DataTable islemler = new DataTable();
            islemler.TableName = "islemler";
            islemler.Columns.Add("toplam", typeof(string));
            islemler.Rows.Add(toplam + " ₺");
            DataSet table = new DataSet();
            table.Tables.Add(is_emri);
            table.Tables.Add(islemler);
            table.Tables.Add(getFirmaTable());
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_is_emri_aciklar.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();

        }
        public static void PrintServiseGelenArac(List<servis> servisler,string tarih)
        {
            DataTable servis_islemleri = new DataTable();
            servis_islemleri.TableName = "servis_islemleri";
            servis_islemleri.Columns.Add("tarih", typeof(string));
            servis_islemleri.Columns.Add("name", typeof(string));
            servis_islemleri.Columns.Add("plaka", typeof(string));
            servis_islemleri.Columns.Add("marka", typeof(string));
            servis_islemleri.Columns.Add("telefon", typeof(string));
            servis_islemleri.Columns.Add("kdv_toplam", typeof(string));
            servis_islemleri.Columns.Add("iscilik_toplam", typeof(string));
            servis_islemleri.Columns.Add("parca_toplam", typeof(string));
            servis_islemleri.Columns.Add("gnl_toplam", typeof(string));
            double parca=0, kdv=0, gnl=0, iscilik=0;
            foreach(servis item in servisler)
            {
                double parca_toplam, kdv_toplam, gnl_toplam, iscilik_toplam;
                GetToplam(item.id, out kdv_toplam, out parca_toplam, out gnl_toplam, out iscilik_toplam);
                musteri musteri = frm_ana_sayfa.db.musteris.FirstOrDefault(m => m.id == item.musteri_id);
                servis_islemleri.Rows.Add(item.tarih, musteri.ad, musteri.plaka,musteri.model, musteri.tel, kdv_toplam + " ₺", iscilik_toplam + " ₺", parca_toplam + " ₺", gnl_toplam + " ₺");
                parca += parca_toplam;
                kdv += kdv_toplam;
                gnl += gnl_toplam;
                iscilik += iscilik_toplam;
            }
            DataTable servis_table = new DataTable();
            servis_table.TableName = "servis";
            servis_table.Columns.Add("tarih", typeof(string));
            servis_table.Columns.Add("kdv_toplam", typeof(string));
            servis_table.Columns.Add("iscilik_toplam", typeof(string));
            servis_table.Columns.Add("gnl_toplam", typeof(string));
            servis_table.Columns.Add("parca_toplam", typeof(string));
            servis_table.Rows.Add(tarih, kdv + " ₺", iscilik + " ₺", gnl + " ₺", parca + " ₺");
            DataSet table = new DataSet();
            table.Tables.Add(servis_table);
            table.Tables.Add(servis_islemleri);
            table.Tables.Add(getFirmaTable());
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_servis_gelen_arac.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();
        }
        public static void PrintPersonelUcret(List<personel_islemleri> temp, string tarih)
        {
            DataTable data_personel = new DataTable();
            data_personel.Columns.Add("personel_name", typeof(string));
            data_personel.Columns.Add("aldigi_ucret", typeof(string));
            data_personel.Columns.Add("tarih", typeof(string));
            data_personel.Columns.Add("odeme_tipi", typeof(string));
            data_personel.TableName = "personel";
            double toplam = 0;
            foreach (personel_islemleri item in temp)
            {
                toplam += item.ucret;
                personel personel = frm_ana_sayfa.db.personels.FirstOrDefault(p => p.id == item.personel_id);
                data_personel.Rows.Add(personel.ad, item.ucret + " ₺", item.tarih, item.aciklama);
            }
            DataTable data_toplam = new DataTable();
            data_toplam.TableName = "toplam";
            data_toplam.Columns.Add("Toplam");
            data_toplam.Columns.Add("tarih");
            data_toplam.Rows.Add(toplam + " ₺",tarih);
            DataSet table = new DataSet();
            table.Tables.Add(getFirmaTable());
            table.Tables.Add(data_personel);
            table.Tables.Add(data_toplam);
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_personel_ucret.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();

        }
        public static void PrintPersonelKart(List<personel> personels)
        {
            DataTable data_personel = new DataTable();
            data_personel.Columns.Add("personel_name", typeof(string));
            data_personel.Columns.Add("telefon", typeof(string));
            data_personel.Columns.Add("bolum", typeof(string));
            data_personel.Columns.Add("ucret", typeof(string));
            data_personel.TableName = "personel";
            foreach (personel item in personels)
                data_personel.Rows.Add(item.ad, item.telefon, item.bolum, item.ucret + " ₺");
            DataSet table = new DataSet();
            table.Tables.Add(getFirmaTable());
            table.Tables.Add(data_personel);
            Report report = new Report();
            report.Load(getPath() + @"\Rapor\Rapor_personel_kart.frx");
            report.RegisterData(table);
            report.Show();
            report.Dispose();
        }
        public static void PrintTedarik(List<tedarik> tedariks, string name, string tel)
        {
            DataTable table = new DataTable();
            table.Columns.Add("tedarikci_adi", typeof(string));
            table.Columns.Add(nameof(tel), typeof(string));
            table.Columns.Add("tarih", typeof(string));
            table.Columns.Add("toplam", typeof(string));
            table.TableName = "tedarikci";
            foreach (tedarik tedarik in tedariks)
                table.Rows.Add((object)name, (object)tel, (object)tedarik.zaman, (object)(tedarik.toplam.ToString() + " ₺"));
            DataSet data = new DataSet();
            data.Tables.Add(table);
            data.Tables.Add(print.getFirmaTable());
            Report report = new Report();
            report.Load(print.getPath() + "\\Rapor\\Rapor_tedarik.frx");
            report.RegisterData(data);
            report.Show();
            report.Dispose();
        }
        public static void PrintStok(List<urun> uruns)
        {
            DataTable table = new DataTable();
            table.Columns.Add("stok_kodu", typeof(string));
            table.Columns.Add("adi", typeof(string));
            table.Columns.Add("birim", typeof(string));
            table.Columns.Add("kdv", typeof(string));
            table.Columns.Add("fiyat", typeof(string));
            table.Columns.Add("stok", typeof(string));
            table.TableName = "stok_durum";
            foreach (urun urun in uruns)
                table.Rows.Add((object)urun.kodu, (object)urun.adi, (object)urun.birim, (object)("% " + (object)urun.kdv), (object)(urun.satis.ToString() + " ₺"), (object)string.Concat((object)urun.stok));
            DataSet data = new DataSet();
            data.Tables.Add(table);
            data.Tables.Add(print.getFirmaTable());
            Report report = new Report();
            report.Load(print.getPath() + "\\Rapor\\Rapor_stok.frx");
            report.RegisterData(data);
            report.Show();
            report.Dispose();
        }
        public static void PrintTedarik(List<tedarik> tedariks)
        {
            DataTable table = new DataTable();
            table.Columns.Add("tedarikci_adi", typeof(string));
            table.Columns.Add("tel", typeof(string));
            table.Columns.Add("tarih", typeof(string));
            table.Columns.Add("toplam", typeof(string));
            table.TableName = "tedarikci";
            foreach (tedarik tedarik in tedariks)
            {
                tedarik item = tedarik;
                musteri musteri = frm_ana_sayfa.db.musteris.FirstOrDefault<musteri>((Expression<Func<musteri, bool>>)(m => m.id == item.toptanci_id));
                table.Rows.Add((object)musteri.ad, (object)musteri.tel, (object)item.zaman, (object)(item.toplam.ToString() + " ₺"));
            }
            DataSet data = new DataSet();
            data.Tables.Add(table);
            data.Tables.Add(print.getFirmaTable());
            Report report = new Report();
            report.Load(print.getPath() + "\\Rapor\\Rapor_tedarik.frx");
            report.RegisterData(data);
            report.Show();
            report.Dispose();
        }
        public static void PrintStokGiris(List<stok_giris> stoks,string name,string tarih)
        {
            DataTable table = new DataTable();
            table.Columns.Add("kodu", typeof(string));
            table.Columns.Add("adi", typeof(string));
            table.Columns.Add("birim", typeof(string));
            table.Columns.Add("kdv", typeof(string));
            table.Columns.Add("miktar", typeof(string));
            table.Columns.Add("fiyat", typeof(string));
            table.Columns.Add("toplam", typeof(string));
            table.TableName = "stok_giris";
            foreach (stok_giris item in stoks)
                table.Rows.Add(item.urun.kodu, item.urun.adi, item.urun.birim, item.kdv, item.adet, item.fiyat, item.tutar);
            DataTable bilgiler = new DataTable();
            bilgiler.Columns.Add("Tedarikci", typeof(string));
            bilgiler.Columns.Add("Tarih", typeof(string));
            bilgiler.Rows.Add(name, tarih);
            bilgiler.TableName = "bilgiler";
            DataSet data = new DataSet();
            data.Tables.Add(table);
            data.Tables.Add(bilgiler);
            data.Tables.Add(print.getFirmaTable());
            Report report = new Report();
            report.Load(print.getPath() + "\\Rapor\\Rapor_stok_giris.frx");
            report.RegisterData(data);
            report.Show();
            report.Dispose();
        }
        private static void GetToplam(int servis_id,out double kdv_toplam,out double parca_toplam,out double gnl_toplam,out double iscilik_toplam)
        {
            kdv_toplam = parca_toplam = gnl_toplam = iscilik_toplam = 0;
            List<tamir> tamir = frm_ana_sayfa.db.tamirler.Where(t => t.servis_id == servis_id).ToList();
            foreach (tamir item in tamir)
            {
                item.yedek_parca = frm_ana_sayfa.db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                if (item.yedek_parca != null)
                {
                    gnl_toplam += item.yedek_parca.tutar;
                    kdv_toplam += (item.yedek_parca.fiyat * (item.yedek_parca.kdv / 100))*item.yedek_parca.adet;
                    if (item.iscilik == iscilik_turu.yedek_parca)
                        parca_toplam += item.yedek_parca.fiyat*item.yedek_parca.adet;
                    else iscilik_toplam += item.yedek_parca.fiyat * item.yedek_parca.adet;
                }
            }
        }
        private static double getToplam(int servis_id)
        {
            double toplam = 0;
            List<tamir> tamir = frm_ana_sayfa.db.tamirler.Where(t => t.servis_id == servis_id).ToList();
            foreach (tamir item in tamir)
            {
                item.yedek_parca = frm_ana_sayfa.db.yedek_parca.FirstOrDefault(y => y.tamir_id == item.id);
                if (item.yedek_parca != null)
                    toplam += item.yedek_parca.tutar;
            }
            return toplam;
        } 
    }
}
