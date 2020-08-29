using BookIT.WinUI.DodatneUsluge;
using BookIT.WinUI.Drzave;
using BookIT.WinUI.Fakture;
using BookIT.WinUI.Korisnici;
using BookIT.WinUI.Lokacije;
using BookIT.WinUI.MojProfil;
using BookIT.WinUI.Properties;
using BookIT.WinUI.Rezervacije;
using BookIT.WinUI.Smjestaji;
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
    public partial class frmMainAdmin : Form
    {
        private readonly int initialWidth;

        private frmMojProfil frmMojProfil;
        private frmDodatneUsluge frmDodatneUsluge;
        private frmKorisniciDetalji frmKorisniciDodaj;
        private frmKorisnici frmKorisniciPretraga;
        private frmDrzave frmDrzave;
        private frmGradovi frmGradovi;

        public frmMainAdmin()
        {
            InitializeComponent();
            initialWidth = this.Size.Width;
        }

        void CleanupForms()
        {
            if(frmKorisniciDodaj != null)
            {
                frmKorisniciDodaj.AutoValidate = AutoValidate.Disable;
                frmKorisniciDodaj.Close();
            }
            frmKorisniciPretraga?.Close();
            frmDodatneUsluge?.Close();
            frmGradovi?.Close();
            frmDrzave?.Close();
            frmMojProfil?.Close();
        }
   

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnMojProfil_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmMojProfil = new MojProfil.frmMojProfil();
            frmMojProfil.Show();

            UpdateSizeAndLocation(frmMojProfil);

        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            CleanupForms();
        }

        private void btnKorisniciDodaj_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmKorisniciDodaj = new Korisnici.frmKorisniciDetalji();
            frmKorisniciDodaj.Show();

            UpdateSizeAndLocation(frmKorisniciDodaj);
        }


        private void btnKorisniciPretraga_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmKorisniciPretraga = new Korisnici.frmKorisnici(this);
            frmKorisniciPretraga.Show();

            UpdateSizeAndLocation(frmKorisniciPretraga);
        }


        private void btnDodatneUsluge_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmDodatneUsluge = new DodatneUsluge.frmDodatneUsluge();
            frmDodatneUsluge.Show();

            UpdateSizeAndLocation(frmDodatneUsluge);
        }


        private void btnDrzave_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmDrzave = new Drzave.frmDrzave();
            frmDrzave.Show();

            UpdateSizeAndLocation(frmDrzave);
        }

        private void btnGradovi_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmGradovi = new Lokacije.frmGradovi();
            frmGradovi.Show();

            UpdateSizeAndLocation(frmGradovi);
        }

        private void btnLokacije_Click(object sender, EventArgs e)
        {
            CleanupForms();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnKorisnici_MouseEnter(object sender, EventArgs e)
        {
            btnKorisnici.Image = Resources.korisnici_hover;
            btnLokacije.Image = Resources.lokacije;
            btnKorisniciDodaj.Visible = true;
            btnKorisniciPretraga.Visible = true;
            btnGradovi.Visible = false;
            btnDrzave.Visible = false;
        }


        private void btnMojProfil_MouseEnter(object sender, EventArgs e)
        {
            btnMojProfil.Image = Resources.profil_hover;

            btnKorisniciDodaj.Visible = false;
            btnKorisniciPretraga.Visible = false;
            btnGradovi.Visible = false;
            btnDrzave.Visible = false;
 
            btnKorisnici.Image = Resources.korisnici;
            btnLokacije.Image = Resources.lokacije;

        }

        private void btnMojProfil_MouseLeave(object sender, EventArgs e)
        {
            btnMojProfil.Image = Resources.profil;

        }

        private void btnDodatneUsluge_MouseEnter(object sender, EventArgs e)
        {
            btnDodatneUsluge.Image = Resources.dodatne_usluge_hover;

            btnKorisniciDodaj.Visible = false;
            btnKorisniciPretraga.Visible = false;
            btnGradovi.Visible = false;
            btnDrzave.Visible = false;

            btnKorisnici.Image = Resources.korisnici;
            btnLokacije.Image = Resources.lokacije;

        }

        private void btnFakture_MouseLeave(object sender, EventArgs e)
        {
            btnDodatneUsluge.Image = Resources.dodatne_usluge;

        }


        private void btnLokacije_MouseEnter(object sender, EventArgs e)
        {
            btnLokacije.Image = Resources.lokacije_hover;
            btnKorisnici.Image = Resources.korisnici;

            btnKorisniciDodaj.Visible = false;
            btnKorisniciPretraga.Visible = false;
            btnGradovi.Visible = true;
            btnDrzave.Visible = true;
        }


        private void btnKorisniciPretraga_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.korisnici_pretraga_hover;
        }

        private void btnKorisniciPretraga_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.korisnici_pretraga;

        }

        private void btnKorisniciDodaj_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.korisnici_dodaj_hover;

        }

        private void btnKorisniciDodaj_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.korisnici_dodaj;

        }


        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int newWidth = initialWidth;
            if (sender is frmKorisnici)
            {
                this.frmKorisniciPretraga = null;
            }
            if (sender is frmKorisniciDetalji)
            {
                this.frmKorisniciDodaj = null;
            }
            if (sender is frmMojProfil)
            {
                this.frmMojProfil = null;
            }
            if (sender is frmDodatneUsluge)
            {
                this.frmDodatneUsluge = null;
            }
            if (sender is frmGradovi)
            {
                this.frmGradovi = null;
            }
            if (sender is frmDrzave)
            {
                this.frmDrzave = null;
            }

            Form activeFrm = null;
            if (this.frmKorisniciPretraga != null)
            {
                activeFrm = this.frmKorisniciPretraga;
            }
            if (this.frmKorisniciDodaj != null)
            {
                activeFrm = this.frmKorisniciDodaj;
            }
            if (this.frmMojProfil != null)
            {
                activeFrm = this.frmMojProfil;
            }
            if (this.frmGradovi != null)
            {
                activeFrm = this.frmGradovi;
            }
            if (this.frmDrzave != null)
            {
                activeFrm = this.frmDrzave;
            }

            if (activeFrm != null)
            {
                newWidth = btnKorisnici.Width + activeFrm.Width;
            }

            this.Width = newWidth;
            this.panel1.Width = newWidth;
            this.close.Location = new Point(this.Width - 24, 5);
        }

 

        public void UpdateSizeAndLocation(Form frm)
        {
            this.Width = btnKorisnici.Width + frm.Width;

            panel1.Width = this.Width;

            this.close.Location = new Point(this.Width - 24, 5);

            frm.Location = new Point(this.Location.X + btnKorisnici.Width + 1, this.Location.Y + btnMojProfil.Location.Y);
            frm.FormClosed += Frm_FormClosed;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            APIService.PrijavljeniKorisnik = null;

            frmLogin login = new frmLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Dispose();
                    frm.Close();
                }
                Hide();

                Form frmNew = null;
                if (APIService.PrijavljeniKorisnik.Uloga.Naziv == "Vlasnik smještaja")
                {
                    frmNew = new frmMain();
                }
                else
                {
                    frmNew = new frmMainAdmin();

                }

                frmNew.ShowDialog();
                Close();

            }
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.logout_hover;

        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.logout;
        }

    }
}
