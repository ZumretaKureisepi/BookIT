using BookIT.WinUI.Helpers;
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
    public partial class frmRegistracija : Form
    {
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");
        private frmLogin frmLogin { get; set; }


        public frmRegistracija(frmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private async void frmRegistracija_Load(object sender, EventArgs e)
        {
            gbxPassword.Text = "Unesite lozinku";

            await BindForm();
        }

        private async Task BindForm()
        {
            var lokacijeList = await _apiServiceGradovi.Get<List<Model.Grad>>(null);

            cmbLokacije.ValueMember = "GradId";
            cmbLokacije.DisplayMember = "Grad_Drzava";
            cmbLokacije.DataSource = lokacijeList;

        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var request = new Model.Requests.KorisniciRegistracijaRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Adresa = txtAdresa.Text,
                BrojMobitela = txtTelefon.Text,
                Email = txtEmail.Text,
                Password = txtLozinka.Text,
                PasswordPotvrda = txtPotvrdaLozinke.Text,
                GradId = (cmbLokacije.SelectedItem as Model.Grad).GradId,
                UlogaIme = "Vlasnik smještaja"
            };

            Model.Korisnik entity;

            entity = await _apiServiceKorisnici.Insert<Model.Korisnik>(request, "register");


            if (entity != null)
            {
                MessageBox.Show("Uspješno ste se registrovali!");
                APIService.Username = request.Email;
                APIService.Password = request.Password;
                APIService.PrijavljeniKorisnik = await _apiServiceKorisnici.Get<Model.Korisnik>(null, "currentUser");

                Close();
                frmLogin.DialogResult = DialogResult.OK;

            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
            }
            else if (!Helpers.ValidationHelper.IsAlphabetic(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Properties.Resources.Validation_FormatInvalid);
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
            }
            else if (!Helpers.ValidationHelper.IsAlphabetic(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_FormatInvalid);
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }


        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
            }
            else if (!ValidationHelper.IsValidEmailAddress(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_EmailInvaild);
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }

        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Properties.Resources.Validation_RequiredField);
            }
            else if (txtLozinka.Text.Length < 6)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, string.Format(Properties.Resources.Validation_MinLength, 6));
            }
            else if (!Helpers.ValidationHelper.IsValidPassword(txtLozinka.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Properties.Resources.Validation_PasswordInvalid);
            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
            }

        }

        private void txtPotvrdaLozinke_Validating(object sender, CancelEventArgs e)
        {

            if (txtLozinka.Text != txtPotvrdaLozinke.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrdaLozinke, Properties.Resources.Validation_PasswordNotMatching);
            }
            else
            {
                errorProvider.SetError(txtPotvrdaLozinke, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtAdresa, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
            }
            else if (!Helpers.ValidationHelper.IsValidPhoneNumber(txtTelefon.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_PhoneNumberInvalid);

            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }



        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbLokacije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }

        private void cmbLokacije_Validating(object sender, CancelEventArgs e)
        {
            var cmbBox = sender as ComboBox;
            if (cmbBox.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbBox, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(cmbBox, null);
            }
        }

        private void frmRegistracija_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 4),
                         this.DisplayRectangle);
        }
    }
}
