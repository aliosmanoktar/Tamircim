using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamircim
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        static string[] args;
        [STAThread]
        static void Main(string[] arg)
        {
            new SQLiteConfiguration();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (arg.Length == 0)
            {
                Application.Run(new frm_ana_sayfa());
            }
            else
            {
                args = arg;
                firma firma = new firma()
                {
                    adres = getValue("-adres"),
                    firma_mail = getValue("-mail"),
                    mersis_no = getValue("-mersis"),
                    name = getValue("-name"),
                    sicil_no = getValue("-sicil"),
                    tel = getValue("-tel"),
                    vergi_dairesi = getValue("-vergi_dairesi"),
                    vergi_no = getValue("-vergi_no")
                };
                Application.Run(new frm_ana_sayfa(firma));
            }
        }
        static string getValue(string key)
        {
            for (int i = 0; i < args.Length; i++)
                if (args[i] == key)
                    return args[i + 1];
            return "";
        }
    }
}
