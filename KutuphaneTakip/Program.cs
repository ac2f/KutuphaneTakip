using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AccessDB accdb = new AccessDB("db.accdb");
            accdb.AddNewTable("uyeler", "Uyeler");
            accdb.AddNewTable("kitaplar", "Kitaplar");
            accdb.AddNewTable("emanet-kitaplar", "EmanetKitaplar");
            accdb.AddNewTable("sepet", "Sepet");
            Application.Run(new AnaForm(accdb));
        }
    }
}
