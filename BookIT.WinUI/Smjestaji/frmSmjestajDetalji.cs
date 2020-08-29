using BookIT.Model;
using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Smjestaji
{
    public partial class frmSmjestajDetalji : Form
    {
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        private readonly APIService _apiServiceSmjestaji = new APIService("Smjestaji");
        private readonly APIService _apiServiceDodatneUsluge = new APIService("DodatneUsluge");
        private readonly APIService _apiServiceDodatneUslugeSmjestaji = new APIService("DodatneUslugeSmjestaji");



        private int _smjestajId { get; set; }//geter nije ovdje zato sto je privatni atribut i moze mu pristupiti samo isti objekat
        public Form CallerForm { get; }
        public int SmjestajId { get => _smjestajId; }
        public Smjestaj Smjestaj { get; private set; }

        public frmSmjestajDetalji(int SmjestajId, Form callerForm)
        {
            _smjestajId = SmjestajId;
            CallerForm = callerForm;
            InitializeComponent();
        }

        

        private async void frmSmjestajDetalji_Load(object sender, EventArgs e)
        {
            Smjestaj = await _apiServiceSmjestaji.GetById<Model.Smjestaj>(_smjestajId);
            
            txtCijenaSmjestaja.Text = Smjestaj.Cijena?.ToString();

            this.Text = Smjestaj.Naziv;
            lblNazivSmjestaja.Text = Smjestaj.Naziv;

            var result = await _apiServiceGradovi.Get<List<Model.Grad>>(null);
            cmbLokacije.ValueMember = "GradId";
            cmbLokacije.DisplayMember = "Grad_Drzava";

            cmbTipSmjestaja.DataSource = Enum.GetValues(typeof(Model.TipSmjestaja));
            clbTipDestinacije.DataSource = Enum.GetValues(typeof(Model.TipDestinacije));

            for (int i = 0; i < clbTipDestinacije.Items.Count; i++)
            {
                foreach (var item in Smjestaj.SmjestajTipDestinacije)
                {
                    if(item.TipDestinacije == (clbTipDestinacije.Items[i] as Model.TipDestinacije?))
                    {
                        clbTipDestinacije.SetItemChecked(i, true);
                    }
                }
            }

            cmbLokacije.DataSource = result;
            foreach (Model.Grad item in cmbLokacije.Items)
            {
                if (item.GradId == Smjestaj.Grad.GradId)
                    cmbLokacije.SelectedItem = item;

            }

            cmbTipSmjestaja.SelectedItem = Smjestaj.TipSmjestaja;
            txtAdresa.Text = Smjestaj.Adresa;
            txtOpis.Text = Smjestaj.Opis;

            lblLatitude.Text = Smjestaj.Latitude.ToString("0.00000");
            lblLongitude.Text = Smjestaj.Longitude.ToString("0.00000");

            var resultDodatneUsluge = await _apiServiceDodatneUsluge.Get<List<Model.DodatnaUsluga>>(null);
            cmbDodatneUsluge.DataSource = resultDodatneUsluge;

            await RefreshDodatneUsluge();

        }


        private async Task RefreshDodatneUsluge()
        {
            var search1 = new DodatneUslugeSmjestajiSearchRequest()
            {
                SmjestajId = _smjestajId
            };

            var resultUsluge = await _apiServiceDodatneUslugeSmjestaji.Get<List<Model.DodatnaUslugaSmjestaj>>(search1);
            dgvDodatneUsluge.AutoGenerateColumns = false;
            dgvDodatneUsluge.DataSource = resultUsluge;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            txtCijena.Enabled = false;
            var validationResult = ValidateChildren(ValidationConstraints.Enabled);
            txtCijena.Enabled = true;
            if (!validationResult)
                return;

            double.TryParse(txtCijenaSmjestaja.Text, out double val);

            var resultSmjestaj = await _apiServiceSmjestaji.GetById<Model.Smjestaj>(_smjestajId);
            resultSmjestaj.Cijena = val;
            resultSmjestaj.Adresa = txtAdresa.Text;
            resultSmjestaj.GradId = ((Model.Grad)cmbLokacije.SelectedItem).GradId;
            resultSmjestaj.TipSmjestaja = (Model.TipSmjestaja)cmbTipSmjestaja.SelectedIndex;
            resultSmjestaj.Opis = txtOpis.Text;
            resultSmjestaj.Latitude = double.TryParse(lblLatitude.Text, out double lat) ? lat : 0;
            resultSmjestaj.Longitude = double.TryParse(lblLongitude.Text, out double lng) ? lng : 0;

            resultSmjestaj.SmjestajTipDestinacije.Clear();
            var checkedItems = clbTipDestinacije.CheckedItems.Cast<Model.TipDestinacije>().ToList();
            foreach (var item in checkedItems)
            {
                resultSmjestaj.SmjestajTipDestinacije.Add(new Model.SmjestajTipDestinacije
                {
                    TipDestinacije = item
                });
            }

            Model.Smjestaj entity = await _apiServiceSmjestaji.Update<Model.Smjestaj>(resultSmjestaj.SmjestajId,resultSmjestaj);
            if (entity != null)
                MessageBox.Show("Uspješno ste uredili podatke o smještaju!");
            else
                MessageBox.Show("Greška");
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            txtAdresa.Enabled = false;
            var validationResult = ValidateChildren(ValidationConstraints.Enabled);
            txtAdresa.Enabled = true;
            if (!validationResult)
                return;

            Model.Requests.DodatneUslugeSmjestajiInsertRequest request = new DodatneUslugeSmjestajiInsertRequest()
            {
                Cijena = float.Parse(txtCijena.Text),
                DodatnaUslugaId = ((Model.DodatnaUsluga)cmbDodatneUsluge.SelectedItem).DodatnaUslugaId,
                SmjestajId = _smjestajId
            };

            var entity=await _apiServiceDodatneUslugeSmjestaji.Insert<Model.DodatnaUslugaSmjestaj>(request);
            if (entity != null)
            {
                await RefreshDodatneUsluge();
                MessageBox.Show("Uspješno ste dodali novu uslugu za smještaj!");
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

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            double value;
            if (!double.TryParse(txtCijena.Text, out value) || value < 0.1)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijena, string.Format(Properties.Resources.Validation_MinValue, 0.1));
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }

        private void btnUrediGaleriju_Click(object sender, EventArgs e)
        {
            var frm = new frmSmjestajSlike(SmjestajId);
            this.Hide();
            frm.Location = this.Location;

            if (CallerForm is frmSmjestaji frmSmjestaji)
            {
                frmSmjestaji.FrmMain.UpdateSizeAndLocation(frm);
            }
            if (CallerForm is frmDodajSmjestaj frmDodajSmjestaj)
            {
                frmDodajSmjestaj.FrmMain.UpdateSizeAndLocation(frm);
            }

            frm.ShowDialog();
            this.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSmjestajDetalji_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void cmbTipSmjestaja_Validating(object sender, CancelEventArgs e)
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

        private void cmbDodatneUsluge_Validating(object sender, CancelEventArgs e)
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

        private void txtOdaberiLokaciju_Click(object sender, EventArgs e)
        {
            var frm = new frmOdaberiLokaciju(Smjestaj);
            this.Hide();
            frm.Location = this.Location;

            if (CallerForm is frmSmjestaji frmSmjestaji)
            {
                frmSmjestaji.FrmMain.UpdateSizeAndLocation(frm);
            }
            if (CallerForm is frmDodajSmjestaj frmDodajSmjestaj)
            {
                frmDodajSmjestaj.FrmMain.UpdateSizeAndLocation(frm);
            }

            if (frm.ShowDialog() == DialogResult.OK)
            {
                lblLatitude.Text = frm.Lat.ToString("0.00000");
                lblLongitude.Text = frm.Lng.ToString("0.00000");
                Smjestaj.Latitude = frm.Lat;
                Smjestaj.Longitude = frm.Lng;
            }
            this.Show();

        }
    }
}
