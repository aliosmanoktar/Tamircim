using System;
using System.Windows.Forms;

namespace Setup
{
    public partial class seriel_control : UserControl
    {
        Form1 item;
        string serial = "DU4WW4aZZexxmsqC";
        public seriel_control(Form1 form)
        {
            item = form;
            InitializeComponent();
        }

        private void seriel_screen_Load(object sender, EventArgs e)
        {

        }

        public void Open()
        {
            item.btn_ileri.Enabled = false;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                string temp = maskedTextBox1.Text.Replace("-", "");
                if (temp.Equals(serial))
                    item.btn_ileri.Enabled = true;
            }
        }
    }
}