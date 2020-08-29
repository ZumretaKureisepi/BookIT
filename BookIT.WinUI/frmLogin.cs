using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                APIService.PrijavljeniKorisnik = await _service.Get<Model.Korisnik>(null, "currentUser");

                if (APIService.PrijavljeniKorisnik.Uloga.Naziv != "Vlasnik smještaja" && APIService.PrijavljeniKorisnik.Uloga.Naziv != "Administrator")
                {
                    MessageBox.Show("Greška", "Nedozovljen pristup aplikaciji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistracija frm = new frmRegistracija(this);
            frm.Show();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                txtUsername.Text = "dalila@book.ba";
            else
                txtUsername.Text = "zumreta@book.ba";

            txtPassword.Text = "test123";
            btnLogin.PerformClick();
        }
    }
}
