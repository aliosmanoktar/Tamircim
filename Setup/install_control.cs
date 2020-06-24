using System;
using System.Windows.Forms;
using System.IO;

namespace Setup
{
    public partial class install_control : UserControl
    {
        double file_length=0;
        double yazilan=0;
        Form1 item;
        public install_control(Form1 frm)
        {
            item = frm;
            InitializeComponent();
        }

        private void install_control_Load(object sender, EventArgs e)
        {
           
        }
        public void install()
        {
            item.btn_ileri.Enabled = false;
            item.btn_geri.Enabled = false;
            string program_files = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim";
            if (!Directory.Exists(program_files))
                Directory.CreateDirectory(program_files);
            if (!Directory.Exists(program_files + @"\Rapor"))
                Directory.CreateDirectory(program_files + @"\Rapor");
            if (!Directory.Exists(program_files + @"\x64"))
                Directory.CreateDirectory(program_files + @"\x64");
            if (!Directory.Exists(program_files + @"\x86"))
                Directory.CreateDirectory(program_files + @"\x86");
            file_length += Resource.EntityFramework.Length;
            file_length += Resource.EntityFramework_SqlServer.Length;
            file_length += Resource.FastReport.Length;
            file_length += Resource.FastReport_Bars.Length;
            file_length += Resource.FastReport_Editor.Length;
            file_length += Resource.Rapor_cariler.Length;
            file_length += Resource.Rapor_cari_ekstre.Length;
            file_length += Resource.Rapor_cari_ekstre_toplu.Length;
            file_length += Resource.Rapor_is_emri_aciklar.Length;
            file_length += Resource.Rapor_musteri_kabul.Length;
            file_length += Resource.Rapor_personel_kart.Length;
            file_length += Resource.Rapor_personel_ucret.Length;
            file_length += Resource.Rapor_servis_gelen_arac.Length;
            file_length += Resource.Rapor_sonuc.Length;
            file_length += Resource.Rapor_stok.Length;
            file_length += Resource.Rapor_stok_giris.Length;
            file_length += Resource.Rapor_tedarik.Length;
            file_length += Resource.SQLite_Interop_x64.Length;
            file_length += Resource.SQLite_Interop_x86.Length;
            file_length += Resource.System_Data_SQLite.Length;
            file_length += Resource.System_Data_SQLite_EF6.Length;
            file_length += Resource.System_Data_SQLite_Linq.Length;
            file_length += Resource.tamircim.Length;
            file_length += Resource.Tamircim1.Length;
            file_length += Resource.Uninstall.Length;
            Save(Resource.EntityFramework, program_files + @"\EntityFramework.dll");
            Save(Resource.EntityFramework_SqlServer, program_files + @"\EntityFramework.SqlServer.dll");
            Save(Resource.FastReport, program_files + @"\FastReport.dll");
            Save(Resource.FastReport_Bars, program_files + @"\FastReport.Bars.dll");
            Save(Resource.FastReport_Editor, program_files + @"\FastReport.Editor.dll");
            Save(Resource.Rapor_cariler, program_files + @"\Rapor\Rapor_cariler.frx");
            Save(Resource.Rapor_cari_ekstre, program_files + @"\Rapor\Rapor_cari_ekstre.frx");
            Save(Resource.Rapor_cari_ekstre_toplu, program_files + @"\Rapor\Rapor_cari_ekstre_toplu.frx");
            Save(Resource.Rapor_is_emri_aciklar, program_files + @"\Rapor\Rapor_is_emri_aciklar.frx");
            Save(Resource.Rapor_musteri_kabul, program_files + @"\Rapor\Rapor_musteri_kabul.frx");
            Save(Resource.Rapor_personel_kart, program_files + @"\Rapor\Rapor_personel_kart.frx");
            Save(Resource.Rapor_personel_ucret, program_files + @"\Rapor\Rapor_personel_ucret.frx");
            Save(Resource.Rapor_servis_gelen_arac, program_files + @"\Rapor\Rapor_servis_gelen_arac.frx");
            Save(Resource.Rapor_sonuc, program_files + @"\Rapor\Rapor_sonuc.frx");
            Save(Resource.Rapor_stok, program_files + @"\Rapor\Rapor_stok.frx");
            Save(Resource.Rapor_stok_giris, program_files + @"\Rapor\Rapor_stok_giris.frx");
            Save(Resource.Rapor_tedarik, program_files + @"\Rapor\Rapor_tedarik.frx");
            Save(Resource.SQLite_Interop_x64, program_files + @"\x64\SQLite.Interop.dll");
            Save(Resource.SQLite_Interop_x86, program_files + @"\x86\SQLite.Interop.dll");
            Save(Resource.System_Data_SQLite, program_files + @"\System.Data.SQLite.dll");
            Save(Resource.System_Data_SQLite_EF6, program_files + @"\System.Data.SQLite.EF6.dll");
            Save(Resource.System_Data_SQLite_Linq, program_files + @"\System.Data.SQLite.Linq.dll");
            Save(Resource.tamircim, program_files + @"\tamircim.db");
            Save(Resource.Tamircim1, program_files + @"\Tamircim.exe");
            Save(Resource.Uninstall, program_files + @"\Uninstall.exe");
            timer1.Enabled = true;
        }
        private void Save(byte[] array,string file_name)
        {
            using (var stream = new FileStream(file_name, FileMode.Create, FileAccess.Write))
            using (var writer = new BinaryWriter(stream))
            {
                var bytesLeft = array.Length;
                var bytesWritten = 0;
                while (bytesLeft > 0)
                {
                    var chunkSize = Math.Min(64, bytesLeft);
                    writer.Write(array, bytesWritten, chunkSize);
                    bytesWritten += chunkSize;
                    yazilan += chunkSize;
                    bytesLeft -= chunkSize;
                    progressBar1.Value =(int) ((yazilan * 100) / file_length);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                item.btn_ileri.Text = "Son";
                item.btn_ileri.Enabled = true;
            }
        }
    }
}