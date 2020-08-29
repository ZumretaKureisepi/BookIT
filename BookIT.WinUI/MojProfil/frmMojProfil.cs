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

namespace BookIT.WinUI.MojProfil
{
    public partial class frmMojProfil : Form
    {
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");


        public int _id { get; set; }

        public frmMojProfil()
        {
            InitializeComponent();
        }

        private async void frmMojProfil_Load(object sender, EventArgs e)
        {


            gbxPassword.Text = "Promijeni lozinku";

            var result = await _apiServiceGradovi.Get<List<Model.Grad>>(null);

            cmbLokacije.ValueMember = "GradId";
            cmbLokacije.DisplayMember = "Grad_Drzava";
            cmbLokacije.DataSource = result;

            Model.Korisnik korisnik = await _apiServiceKorisnici.Get<Model.Korisnik>(null, "currentUser");

            _id = korisnik.KorisnikId;
            var entity = await _apiServiceKorisnici.GetById<Model.Korisnik>(_id);

            txtIme.Text = entity.Ime;
            txtPrezime.Text = entity.Prezime;
            txtAdresa.Text = entity.Adresa;
            txtEmail.Text = entity.Email;
            txtTelefon.Text = entity.BrojMobitela;

            foreach (Model.Grad item in cmbLokacije.Items)
            {
                if (item.GradId == entity.GradId)
                    cmbLokacije.SelectedItem = item;
            }
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var korisnik = await _apiServiceKorisnici.GetById<Model.Korisnik>(_id);

            Model.Requests.KorisniciInsertRequest request = new Model.Requests.KorisniciInsertRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Adresa = txtAdresa.Text,
                BrojMobitela = txtTelefon.Text,
                Email = txtEmail.Text,
                Password = txtLozinka.Text,
                PasswordPotvrda = txtPotvrdaLozinke.Text,
                GradId = (cmbLokacije.SelectedItem as Model.Grad).GradId,
                UlogaId = korisnik.UlogaId
            };

            Model.Korisnik entity;
            entity = await _apiServiceKorisnici.Update<Model.Korisnik>(_id, request);

            if (entity != null)
            {
                APIService.Username = request.Email;
                if(!string.IsNullOrWhiteSpace(request.Password))
                {
                    APIService.Password = request.Password;
                }

                MessageBox.Show("Uspješno ste uredili profil!");
                Close();
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
            if (!string.IsNullOrEmpty(txtLozinka.Text))
            {
                if (txtLozinka.Text.Length < 6)
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

        private void frmMojProfil_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void cmbLokacije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }
    }
}
