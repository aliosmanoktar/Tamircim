using System;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace Setup
{
    public partial class sirket_control : UserControl
    {
        Form1 item;
        public sirket_control(Form1 form)
        {
            item = form;
            InitializeComponent();
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private bool kontrol()
        {
            foreach (Control item in Controls)
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)item;
                    if (item.Text.Length == 0 && !(txt.Name == txt_mersis_no.Name || txt.Name == txt_sicil_no.Name || txt.Name == txt_email.Name) )
                        return false;
                }
            return true;
        }

        private void sirket_control_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
                txt_email_KeyDown(null, null);
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            item.btn_ileri.Enabled = kontrol();
        }

        private void sirket_control_Load(object sender, EventArgs e)
        {

        }
        public firma getFirma()
        {
            return new firma()
            {
                name = txt_unvan.Text,
                firma_adres = txt_adres.Text,
                firma_mail = txt_email.Text,
                mersis_no = txt_mersis_no.Text,
                tel = txt_telefon.Text,
                sicil_no = txt_sicil_no.Text,
                vergi_dairesi = txt_vergi_dairesi.Text,
                vergi_no = txt_vergi_no.Text
            };
        }
        private void txt_vergi_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btn_baglan_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.FileName = "Tamircim.db";
            file.Filter = "Veritabanı |Tamircim.db";
            file.ShowDialog();
            if(file.FileName!="Tamircim.db" && file.FileName.EndsWith(".db"))
            {
                item.save = false;
                SaveSetting(file.FileName);
            }
            else
            {
                return;
            }
            
        }
        private void SaveSetting(string data_path)
        {

            /* string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim";
             File.WriteAllText(path + @"\settings.json", new JavaScriptSerializer().Serialize(new setting()
             {
                 dataBase_path = data_path
             }));*/
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Tamircim";
            File.WriteAllText(path + @"\settings.json", "{\"dataBase_path\":\""+data_path.Replace("\\","\\\\")+"\"}");
            item.btn_ileri.Enabled = true;
            item.btn_ileri.PerformClick();
        }
        public class setting
        {
            public string dataBase_path = "";
        }
    }
   
    
}
