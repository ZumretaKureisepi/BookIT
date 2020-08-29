using BookIT.WinUI.Korisnici;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CultureInfo.CurrentCulture = new CultureInfo("bs-BA");

            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (APIService.PrijavljeniKorisnik.Uloga.Naziv == "Vlasnik smještaja")
                    Application.Run(new frmMain());
                else if (APIService.PrijavljeniKorisnik.Uloga.Naziv == "Administrator")
                    Application.Run(new frmMainAdmin());


            }
        }
    }
}
