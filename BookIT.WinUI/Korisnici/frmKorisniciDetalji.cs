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

namespace BookIT.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");
        private readonly APIService _apiServiceUloge = new APIService("Uloge");


        public int? _id { get; set; }

        public frmKorisniciDetalji(int? korisnikId = null)
        {
            _id = korisnikId;
            InitializeComponent();
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
                gbxPassword.Text = "Promijeni lozinku";
            else
                gbxPassword.Text = "Unesite lozinku";

            await BindForm();
        }

        private async Task BindForm()
        {
            var lokacijeList = await _apiServiceGradovi.Get<List<Model.Grad>>(null);
            var ulogeList = await _apiServiceUloge.Get<List<Model.Uloga>>(null);

            cmbLokacije.ValueMember = "GradId";
            cmbLokacije.DisplayMember = "Grad_Drzava";
            cmbLokacije.DataSource = lokacijeList;

            cmbUloga.DataSource = ulogeList;
            cmbUloga.ValueMember = "UlogaId";
            cmbUloga.DisplayMember = "Naziv";

            if (_id.HasValue)
            {
                var entity = await _apiServiceKorisnici.GetById<Model.Korisnik>(_id.Value);

                txtIme.Text = entity.Ime;
                txtPrezime.Text = entity.Prezime;
                txtAdresa.Text = entity.Adresa;
                txtEmail.Text = entity.Email;
                txtTelefon.Text = entity.BrojMobitela;

                foreach (var uloga in cmbUloga.Items)
                {
                    if (entity.UlogaId == ((Model.Uloga)uloga).UlogaId)
                        cmbUloga.SelectedItem = uloga;
                }

            }
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

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
                UlogaId = (cmbUloga.SelectedItem as Model.Uloga).UlogaId
            };

            Model.Korisnik entity;
            if(_id.HasValue)
            {
                entity = await _apiServiceKorisnici.Update<Model.Korisnik>(_id.Value, request);
            }
            else
            {
                entity = await _apiServiceKorisnici.Insert<Model.Korisnik>(request);
            }

            if(entity != null)
            {
                if(!_id.HasValue)
                MessageBox.Show("Uspješno ste dodali novog korisnika!");
                else
                MessageBox.Show("Uspješno ste uredili podatke o korisniku!");


                Close();
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIme.Text))
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
            if (_id == null)//inserting user
            {
                if (string.IsNullOrWhiteSpace(txtLozinka.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtLozinka, Properties.Resources.Validation_RequiredField);
                }
                else if(txtLozinka.Text.Length<6)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtLozinka, string.Format(Properties.Resources.Validation_MinLength, 6));
                }
                else if(!Helpers.ValidationHelper.IsValidPassword(txtLozinka.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtLozinka, Properties.Resources.Validation_PasswordInvalid);
                }
                else
                {
                    errorProvider.SetError(txtLozinka, null);
                }
            }
            else if(_id != null) // updating user
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

        private void frmKorisniciDetalji_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void cmbUloga_Validating(object sender, CancelEventArgs e)
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

        private void cmbLokacije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }

        private void cmbUloga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }
    }
}
