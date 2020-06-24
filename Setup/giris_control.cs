using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
    public partial class giris_control : UserControl
    {
        bool update=false;
        public giris_control(bool update)
        {
            this.update = update;
            InitializeComponent();
        }
        string txt_install = "Bu sihirbaz, bilgisayarınıza Tamircim'i yüklemenize yardımcı olacaktır.\n\nDevam etmek için İleri'ye tıklayınız";
        string txt_update = "Bu sihirbaz, Tamircim uygulamasını güncellenmenizde yardımcı olacaktır.\n\nDevam etmek içi İleri'ye tıklayınız";
        private void giris_control_Load(object sender, EventArgs e)
        {
            if (update) {
                label2.Text = txt_update;
                label1.Text = "Tamircim Güncelleme Sihirbazı";
            }
            else
            {
                label2.Text = txt_install;
            }
        }
    }
}
