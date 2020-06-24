using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tamircim
{
    [Table("Musteri")]
    public class musteri
    {
        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string ad { get; set; }

        [Column("adres")]
        public string adres { get; set; }

        [Column("vergi_dairesi")]
        public string vergi_dairesi { get; set; }

        [Column("vergi_no")]
        public string vergi_no { set; get; }

        [Column("email")]
        public string email { get; set; }

        [Column("not")]
        public string not { get; set; }

        [Column("plaka")]
        public string plaka { get; set; }

        [Column("sasi")]
        public string sasi { get; set; }

        [Column("model")]
        public string model { get; set; }

        [Column("tel")]
        public string tel { get; set; }

        [Column("motor")]
        public string motor { get; set; }

        [Column("cari")]
        public musteri_type cari { get; set; }

    }

    [Table("servis")]
    public class servis
    {
        [Column("id")]
        [Key]
        public int id { get; set; }

        [Column("musteri_id")]
        public int musteri_id { get; set; }

        [Column("tarih")]
        public string tarih { get; set; }

        [Column("saat")]
        public string saat { get; set; }

        [Column("km")]
        public string km { get; set; }

        [Column("yakit")]
        public string yakit { get; set; }

        [Column("getiren")]
        public string getiren { get; set; }

        [Column("emanet")]
        public string emanet { get; set; }

        [Column("islem_turu")]
        public islem_turu durum { get; set; }

        List<tamir> tamirler;
    }

    [Table("arac_ariza")]
    public class arac_ariza
    {
        [Column("id")]
        public int id { set; get; }

        [Column("servis_id")]
        public int servis_id { set; get; }

        [Column("genel_bakim")]
        public string genel_bakim { get; set; }

        [Column("motor")]
        public string motor { get; set; }

        [Column("sanziman")]
        public string sanziman { get; set; }

        [Column("on_duzen")]
        public string on_duzen { get; set; }

        [Column("arka_duzen")]
        public string arka_duzen { get; set; }

        [Column("frenler")]
        public string frenler { get; set; }

        [Column("elektrik")]
        public string elektrik { get; set; }

        [Column("klima")]
        public string klima { get; set; }

        [Column("karoser")]
        public string karoser { get; set; }

        [Column("diger")]
        public string diger { set; get; }


        [Column("not")]
        public string not { set; get; }
    }

    [Table("cari_islem")]
    public class cari_islemleri
    {
        [Column("id")]
        public int id { set; get; }
        [Column("cari_id")]
        public int musteri_id { set; get; }
        [Column("tur")]
        public cari_islem islem { set; get; }
        [Column("tarih")]
        public string tarih { set; get; }
        [Column("aciklama")]
        public string aciklama { set; get; }
        [Column("borc")]
        public double borc { set; get; }
        [Column("alacak")]
        public double alacak { set; get; }
    }

    [Table("tamir")]
    public class tamir
    {
        [Column("servis_id")]
        public int servis_id { set; get; }
        [Column("id")]
        public int id { set; get; }
        [Column("iscilik_turu")]
        public iscilik_turu iscilik { set; get; }
        public yedek_parca yedek_parca;
    }

    [Table("stok")]
    public class urun
    {
        [Column("id")]
        [Key]
        public int id { set; get; }

        [Column("kodu")]
        public string kodu { set; get; }

        [Column("name")]
        public string adi { set; get; }

        [Column("birim")]
        public string birim { set; get; }

        [Column("kdv")]
        public double kdv { set; get; }

        [Column("satis_fiyat")]
        public double satis { set; get; }

        [Column("stok")]
        public double stok { set; get; }

        [Column("sil")]
        public bool sil { set; get; }
        
        [Column("urun_not")]
        public string not { set; get; }

        [Column("stok_dus")]
        public bool stok_dus { set; get; }
    }

    [Table("yedek_parca")]
    public class yedek_parca
    {
        public urun urun;

        [Column("urun_id")]
        public int urun_id { set; get; }

        [Column("id")]
        public int id { set; get; }

        [Column("tamir_id")]
        public int tamir_id { set; get; }

        [Column("adet")]
        public double adet { set; get; }

        [Column("tutar")]
        public double tutar { set; get; }

        [Column("kdv")]
        public double kdv { set; get; }

        [Column("fiyat")]
        public double fiyat { set; get; }

 
    }

    [Table("personel")]
    public class personel
    {
        [Column("id")]
        public int id { get; set; }

        [Column("ad")]
        public string ad { get; set; }

        [Column("telefon")]
        public string telefon { get; set; }

        [Column("adres")]
        public string adres { get; set; }

        [Column("bolum")]
        public string bolum { get; set; }

        [Column("ucret")]
        public double ucret { get; set; }
    }

    [Table("personel_islemleri")]
    public class personel_islemleri
    {
        [Column("id")]
        public int id { set; get; }

        [Column("personel_id")]
        public int personel_id { set; get; }

        [Column("tarih")]
        public string tarih { set; get; }

        [Column("aciklama")]
        public string aciklama { set; get; }

        [Column("ucret")]
        public double ucret { set; get; }
    }

    [Table("firma")]
    public class firma
    {
        [Column("id")]
        public int id { get; set; }

        [Column("firma_name")]
        public string name { get; set; }

        [Column("firma_tel")]
        public string tel { get; set; }

        [Column("firma_adres")]
        public string adres { get; set; }

        [Column("firma_vergi_dairesi")]
        public string vergi_dairesi { get; set; }

        [Column("firma_vergi_no")]
        public string vergi_no { get; set; }

        [Column("firma_mersis_no")]
        public string mersis_no { get; set; }

        [Column("firma_sicil_no")]
        public string sicil_no { get; set; }

        [Column("firma_mail")]
        public string firma_mail { get; set; }
    }

    [Table("arizalar")]
    public class arizalar
    {
        [Column("id")]
        public int id { set; get; }

        [Column("servis_id")]
        public int servis_id { set; get; }
        
        [Column("ariza")]
        public string ariza { set; get; }

    }
    
    [Table("odemeler")]
    public class odemeler
    {
        [Column("id")]
        public int id { set; get; }
        [Column("servis_id")]
        public int servis_id { set; get; }
        [Column("odeme")]
        public double odeme { set; get; }
        [Column("tarih")]
        public string tarih { set; get; }
        [Column("odeme_turu")]
        public odeme_turu odeme_turu { set; get; }
        
    }
    [Table("Tedarik")]
    public class tedarik
    {
        private List<stok_giris> stok_Girises;

        [Column("id")]
        public int id { set; get; }

        [Column("toptanci_id")]
        public int toptanci_id { set; get; }

        [Column("zaman")]
        public string zaman { set; get; }

        [Column("toplam")]
        public double toplam { set; get; }
    }
    [Table("stok_giris")]
    public class stok_giris
    {
        public urun urun;

        [Column("tedarik_id")]
        public int tedarik_id { set; get; }

        [Column("urun_id")]
        public int urun_id { set; get; }

        [Column("id")]
        public int id { set; get; }

        [Column("adet")]
        public double adet { set; get; }

        [Column("tutar")]
        public double tutar { set; get; }

        [Column("kdv")]
        public double kdv { set; get; }

        [Column("fiyat")]
        public double fiyat { set; get; }
    }
    public enum islem_turu { acik,parca_bekliyor, kapali };
    public enum iscilik_turu{ yedek_parca,yapilan_iscilik };
    public enum cari_islem { cari_islem,nakit,servis};
    public enum musteri_type {musteri,cari,cari_musteri,toptanci }
    public enum odeme_turu { nakit,kart}

}
