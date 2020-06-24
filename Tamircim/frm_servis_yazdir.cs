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
    public partial class frm_servis_yazdir : Form
    {
        public frm_servis_yazdir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void frm_servis_yazdir_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icon1;
        }
    }
}
