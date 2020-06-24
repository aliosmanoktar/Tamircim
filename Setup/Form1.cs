using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static Setup.sirket_control;

namespace Setup
{
    public partial class Form1 : Form
    {
        string path;
        enum Secreen { giris,lisans,install,sirket,serial};
        Secreen scren;
        bool update=false;
        firma firma;
        public bool save=true;
        public Form1()
        {
            update = false;
            InitializeComponent();
        }
        public Form1(bool update)
        {
            InitializeComponent();
            this.update = update;
        }
        giris_control giris_screen;
        install_control install_screen;
        lisans_control lisans_screen;
        sirket_control sirket_screen;
        seriel_control serial_screen;
        private void Form1_Load(object sender, EventArgs e)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim";
            if (!update)
            {
                serial_screen = new seriel_control(this);
                giris_screen = new giris_control(false);
                sirket_screen = new sirket_control(this);
                lisans_screen = new lisans_control(this);
                install_screen = new install_control(this);
                pnl_arayuz.Controls.Add(giris_screen);
                pnl_arayuz.Controls.Add(install_screen);
                pnl_arayuz.Controls.Add(lisans_screen);
                pnl_arayuz.Controls.Add(sirket_screen);
                pnl_arayuz.Controls.Add(serial_screen);
                giris_screen.Visible = true;
                install_screen.Visible = false;
                lisans_screen.Visible = false;
                sirket_screen.Visible = false;
                btn_geri.Visible = false;
                btn_ileri.Click += btn_ileri_Click;
                btn_geri.Click += btn_geri_Click;
            }
            else
            {
                giris_screen = new giris_control(true);
                install_screen = new install_control(this);
                giris_screen.Visible = true;
                install_screen.Visible = false;
                btn_geri.Visible = false;
                pnl_arayuz.Controls.Add(giris_screen);
                pnl_arayuz.Controls.Add(install_screen);
                btn_ileri.Click += btn_update_ileri;
            }
           
        }
        private void KisaYol()
        {
            WshShell shell = new WshShell();
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Tamircim.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.TargetPath = path + @"\Tamircim.exe";
            shortcut.Save();
        }
        private void RegKayit()
        {
            string reg = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(reg, true);
            RegistryKey aKey = key.CreateSubKey("Tamircim");
            aKey.SetValue("DisplayName", "Tamircim");
            aKey.SetValue("InstallLocation", path);
            aKey.SetValue("DisplayIcon",path + @"\Tamircim.exe");
            aKey.SetValue("UninstallString", path + @"\Uninstall.exe");
            aKey.SetValue("DisplayVersion", "v1.0");
            aKey.SetValue("Publisher", "Cats Bilişim");
        }
        private void SaveRegedit()
        {
            string reg = @"Software\";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(reg, true);
            RegistryKey aKey = key.CreateSubKey("Tamircim");
            aKey.SetValue("lisans", sha256(CpuIdCheck() + MacVer() + SystemInformation.ComputerName));
        }
        string sha256(string randomString)
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
        private void btn_update_ileri(object sender,EventArgs e)
        {
            switch (scren)
            {
                case Secreen.giris:
                    btn_geri.Visible = true;
                    giris_screen.Visible = false;
                    install_screen.Visible = true;
                    install_screen.install();
                    scren = Secreen.install;
                    break;
                case Secreen.install:
                    img.BackgroundImage = Properties.Resources.kurulum_tamamlandı;
                    Environment.Exit(0);
                    break;
            }
        }
        private void btn_ileri_Click(object sender, EventArgs e)
        {
            switch (scren)
            {
                case Secreen.giris:
                    img.BackgroundImage = Properties.Resources.lisans;
                    btn_geri.Visible = true;
                    giris_screen.Visible = false;
                    lisans_screen.Visible = true;
                    scren = Secreen.lisans;
                    break;
                case Secreen.lisans:
                    img.BackgroundImage = Properties.Resources.lisans_aktivasyon;
                    lisans_screen.Visible = false;
                    serial_screen.Visible = true;
                    serial_screen.Open();
                    scren = Secreen.serial;
                    break;
                case Secreen.sirket:
                    firma = sirket_screen.getFirma();
                    img.BackgroundImage = Properties.Resources.kurulum_tamamlandı;
                    sirket_screen.Visible = false;
                    install_screen.Visible = true;
                    install_screen.install();
                    scren = Secreen.install;
                    break;
                case Secreen.serial:
                    img.BackgroundImage = Properties.Resources.firma_sabitleri;
                    serial_screen.Visible = false;
                    sirket_screen.Visible = true;
                    scren = Secreen.sirket;
                    btn_ileri.Text = "Yükle";
                    break;
                case Secreen.install:
                    if (!update)
                        callExe();
                    Environment.Exit(0);
                    break;
            }
        }
        private void callExe()
        {
            SaveRegedit();
            KisaYol();
            RegKayit();
            if (save)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim";
                Process myProcess = new Process();
                try
                {
                    myProcess.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim\Tamircim.exe";
                    myProcess.EnableRaisingEvents = false;
                    myProcess.StartInfo.Verb = "runas";
                    myProcess.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim";
                    myProcess.StartInfo.Arguments = string.Format(" -name \"{0}\" -adres \"{1}\" -mail \"{2}\" -sicil \"{3}\" -tel \"{4}\" -vergi_dairesi \"{5}\" -vergi_no \"{6}\"", firma.name, firma.firma_adres, firma.firma_mail, firma.sicil_no, firma.tel, firma.vergi_dairesi, firma.vergi_no);
                    Console.WriteLine(myProcess.StartInfo.Arguments);
                    myProcess.Start();

                }
                catch (Exception)
                {

                }
            }
        }
        private void btn_geri_Click(object sender, EventArgs e)
        {
            switch (scren)
            {
                case Secreen.lisans:
                    img.BackgroundImage = Properties.Resources.giris;
                    scren = Secreen.giris;
                    btn_geri.Visible = false;
                    giris_screen.Visible = true;
                    lisans_screen.Visible = false;
                    break;
                case Secreen.serial:
                    img.BackgroundImage = Properties.Resources.lisans;
                    lisans_screen.Visible = true;
                    scren = Secreen.lisans;
                    serial_screen.Visible = false;
                    btn_ileri.Enabled = true;
                    break;
                case Secreen.sirket:
                    img.BackgroundImage = Properties.Resources.lisans_aktivasyon;
                    serial_screen.Visible = true;
                    sirket_screen.Visible = false;
                    scren = Secreen.serial;
                    btn_ileri.Enabled = true;
                    btn_ileri.Text = "İleri";
                    break;
                case Secreen.install:
                    img.BackgroundImage = Properties.Resources.firma_sabitleri;
                    scren = Secreen.sirket;
                    sirket_screen.Visible = true;
                    install_screen.Visible = false;
                    break;
            }
        }
    }
    public class firma
    {
        public string name;
        public string tel;
        public string firma_adres;
        public string vergi_dairesi;
        public string vergi_no;
        public string mersis_no;
        public string sicil_no;
        public string firma_mail;
    }
}