using BookIT.WinUI.Fakture;
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
    public partial class frmMain : Form
    {
        private readonly int initialWidth;

        private frmDodajSmjestaj frmSmjestajiDodaj;
        private frmSmjestaji frmSmjestajiPretraga;
        private frmFakture frmFakture;
        private frmRezervacije frmRezervacije;
        private frmMojProfil frmMojProfil;

        public frmMain()
        {
            InitializeComponent();

            initialWidth = this.Size.Width;
        }

        void CleanupForms()
        {
            if (frmSmjestajiDodaj != null)
            {
                frmSmjestajiDodaj.AutoValidate = AutoValidate.Disable;
                frmSmjestajiDodaj.Close();
            }
            frmSmjestajiPretraga?.Close();
            frmFakture?.Close();
            frmRezervacije?.Close();
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

        private void btnSmjestaj_Click(object sender, EventArgs e)
        {
            CleanupForms();
        }

        private void btnFakture_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmFakture = new Fakture.frmFakture(this);

            frmFakture.Show();

            UpdateSizeAndLocation(frmFakture);

        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmRezervacije = new Rezervacije.frmRezervacije(this);

            frmRezervacije.Show();

            UpdateSizeAndLocation(frmRezervacije);

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSmjestaj_MouseEnter(object sender, EventArgs e)
        {
            btnSmjestaj.Image = Resources.smjestaj_hover;
            btnSmjestajiDodaj.Visible = true;
            btnSmjestajiPretraga.Visible = true;
        }

        private void btnSmjestaj_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnMojProfil_MouseEnter(object sender, EventArgs e)
        {
            btnMojProfil.Image = Resources.profil_hover;

            btnSmjestajiDodaj.Visible = false;
            btnSmjestajiPretraga.Visible = false;

            btnSmjestaj.Image = Resources.smjestaj;

        }

        private void btnMojProfil_MouseLeave(object sender, EventArgs e)
        {
            btnMojProfil.Image = Resources.profil;

        }

        private void btnFakture_MouseEnter(object sender, EventArgs e)
        {
            btnFakture.Image = Resources.faktura_hover;

            btnSmjestajiDodaj.Visible = false;
            btnSmjestajiPretraga.Visible = false;

            btnSmjestaj.Image = Resources.smjestaj;

        }

        private void btnFakture_MouseLeave(object sender, EventArgs e)
        {
            btnFakture.Image = Resources.faktura;

        }

        private void btnRezervacije_MouseEnter(object sender, EventArgs e)
        {
            btnRezervacije.Image = Resources.rezervacije_hover;

            btnSmjestajiDodaj.Visible = false;
            btnSmjestajiPretraga.Visible = false;

            btnSmjestaj.Image = Resources.smjestaj;

        }

        private void btnRezervacije_MouseLeave(object sender, EventArgs e)
        {
            btnRezervacije.Image = Resources.rezervacije;
        }

        private void btnSmjestajiPretraga_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.smjestaj_pretraga_hover;
        }

        private void btnSmjestajiPretraga_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.smjestaj_pretraga;

        }

        private void btnSmjestajiDodaj_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.smjestaj_dodaj_hover;

        }

        private void btnSmjestajiDodaj_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Resources.smjestaj_dodaj;

        }

        private void btnSmjestajiPretraga_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmSmjestajiPretraga = new frmSmjestaji(this);

            frmSmjestajiPretraga.Show();

            UpdateSizeAndLocation(frmSmjestajiPretraga);
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int newWidth = initialWidth;
            if (sender is frmRezervacije)
            {
                this.frmRezervacije = null;
            }
            if (sender is frmFakture)
            {
                this.frmFakture = null;
            }
            if (sender is frmMojProfil)
            {
                this.frmMojProfil = null;
            }

            if (sender is frmDodajSmjestaj)
            {
                this.frmSmjestajiDodaj = null;
            }

            if (sender is frmSmjestaji)
            {
                this.frmSmjestajiPretraga = null;
            }
            if (sender is frmSmjestajDetaljiSobe && this.frmSmjestajiPretraga != null)
            {
                this.frmSmjestajiPretraga.ChildForm = null;
            }
            if (sender is frmSmjestajDetalji && this.frmSmjestajiPretraga != null)
            {
                this.frmSmjestajiPretraga.ChildForm = null;
            }
            if (sender is frmSmjestajDetaljiSobe && this.frmSmjestajiDodaj != null)
            {
                this.frmSmjestajiDodaj.ChildForm = null;
            }
            if (sender is frmSmjestajDetalji && this.frmSmjestajiDodaj != null)
            {
                this.frmSmjestajiDodaj.ChildForm = null;
            }


            if (sender is frmUrediSobu && this.frmSmjestajiDodaj != null)
            {
                if(this.frmSmjestajiDodaj.ChildForm is frmSmjestajDetaljiSobe frmSmjestajDetaljiSobe)
                {
                    if(frmSmjestajDetaljiSobe.ChildForm == sender)
                    {
                        frmSmjestajDetaljiSobe.ChildForm = null;
                    }
                }
            }
            if (sender is frmUrediSobu && this.frmSmjestajiPretraga != null)
            {
                if(this.frmSmjestajiPretraga.ChildForm is frmSmjestajDetaljiSobe frmSmjestajDetaljiSobe)
                {
                    if(frmSmjestajDetaljiSobe.ChildForm == sender)
                    {
                        frmSmjestajDetaljiSobe.ChildForm = null;
                    }
                }
            }

            Form activeFrm = null;
            if (this.frmRezervacije != null)
            {
                activeFrm = this.frmRezervacije;
            }
            if (this.frmFakture != null)
            {
                activeFrm = this.frmFakture;
            }
            if (this.frmMojProfil != null)
            {
                activeFrm = this.frmMojProfil;
            }
            if (this.frmSmjestajiDodaj != null)
            {
                activeFrm = this.frmSmjestajiDodaj;
                if (this.frmSmjestajiDodaj.ChildForm != null)
                {
                    activeFrm = this.frmSmjestajiDodaj.ChildForm;
                    if (this.frmSmjestajiDodaj.ChildForm is frmSmjestajDetaljiSobe frmSmjestajDetaljiSobe)
                    {
                        if (frmSmjestajDetaljiSobe.ChildForm is frmUrediSobu)
                        {
                            activeFrm = frmSmjestajDetaljiSobe.ChildForm;
                        }
                    }
                }
            }
            if (this.frmSmjestajiPretraga != null)
            {
                activeFrm = this.frmSmjestajiPretraga;
                if(this.frmSmjestajiPretraga.ChildForm != null)
                {
                    activeFrm = this.frmSmjestajiPretraga.ChildForm;
                    if(this.frmSmjestajiPretraga.ChildForm is frmSmjestajDetaljiSobe frmSmjestajDetaljiSobe)
                    {
                        if(frmSmjestajDetaljiSobe.ChildForm is frmUrediSobu)
                        {
                            activeFrm = frmSmjestajDetaljiSobe.ChildForm;
                        }
                    }
                }
            }

            if(activeFrm != null)
            {
                newWidth = btnSmjestaj.Width + activeFrm.Width;
            }

            this.Width = this.panel1.Width = this.label1.Width = newWidth;
            this.close.Location = new Point(this.Width - 24, 5);
        }

        private void btnSmjestajiDodaj_Click(object sender, EventArgs e)
        {
            CleanupForms();

            frmSmjestajiDodaj = new frmDodajSmjestaj(this);
            frmSmjestajiDodaj.Show();

            UpdateSizeAndLocation(frmSmjestajiDodaj);
        }

        public void UpdateSizeAndLocation(Form frm)
        {
            //if (btnSmjestaj.Width + frm.Width < initialWidth)
            //{
            //    this.Width = initialWidth;
            //    frm.Width = initialWidth - btnSmjestaj.Width;
            //}
            //else
            this.Width = panel1.Width = this.label1.Width = btnSmjestaj.Width + frm.Width;

            this.close.Location = new Point(this.Width - 24, 5);

            frm.Location = new Point(this.Location.X + btnSmjestaj.Width - 2, this.Location.Y + btnMojProfil.Location.Y);
            if (frm.Height < 539)
                frm.Height = 539;

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
