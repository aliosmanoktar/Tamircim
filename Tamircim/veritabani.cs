using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace Tamircim
{
    public class veritabani : DbContext
    {
        public veritabani() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() {
                    //DataSource = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim\tamircim.db"
                    DataSource=@".\tamircim.db"
                }.ConnectionString
            }, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<musteri> musteris { get; set; }
        public DbSet<servis> servis { get; set; }
        public DbSet<arac_ariza> arac_ariza { get; set; }
        public DbSet<urun> urunler { get; set; }
        public DbSet<tamir> tamirler { get; set; }
        public DbSet<yedek_parca> yedek_parca { set; get; }
        public DbSet<cari_islemleri> cari_islemeler { set; get; }
        public DbSet<personel> personels { set; get; }
        public DbSet<personel_islemleri> personel_islemleri { set; get; }
        public DbSet<firma> firma { get; set; }
        public DbSet<arizalar> arizalar { set; get; }
        public DbSet<odemeler> odemeler { set; get; }
        public DbSet<stok_giris> stok_girisleri { set; get; }

        public DbSet<tedarik> tedarik_islemleri { set; get; }
    }
}