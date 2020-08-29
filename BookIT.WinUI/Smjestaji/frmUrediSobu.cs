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
    public partial class frmUrediSobu : Form
    {
        private readonly APIService _apiServiceSobe = new APIService("Sobe");
        private readonly APIService _apiServiceDodatneUsluge = new APIService("DodatneUsluge");
        private readonly APIService _apiDodatneUslugeSobe = new APIService("DodatneUslugeSobe");

        private frmSmjestajDetaljiSobe CallerForm { get; set; }
        private int? _sobaId { get; set; }
        public frmUrediSobu(frmSmjestajDetaljiSobe callerForm, int? SobaId=null)
        {
            _sobaId = SobaId;
            CallerForm = callerForm;
            InitializeComponent();
        }

        private async void frmUrediSobu_Load(object sender, EventArgs e)
        {

            var resultDodatneUsluge = await _apiServiceDodatneUsluge.Get<List<Model.DodatnaUsluga>>(null);
            cmbDodatneUsluge.DataSource = resultDodatneUsluge;

            if (_sobaId != null)
            {
                var entity = await _apiServiceSobe.GetById<Model.Soba>(_sobaId.Value);//pohranimo objekt u varijablu da bismo mogli izvuci atribute

                txtNazivSobe.Text = entity.Naziv;
                txtBrojMalihKreveta.Text = entity.BrojMalihKreveta.ToString();
                txtBrojVelikihKreveta.Text = entity.BrojVelikihKreveta.ToString();
                txtVelicinaSobe.Text = entity.VelicinaSobe.ToString();
                txtCijena.Text = entity.Cijena.ToString("0.00");
                await RefreshDodatneUslugeSobe();

            }
        }

        private async Task RefreshDodatneUslugeSobe()
        {
            var request = new Model.Requests.DodatneUslugeSobeSearchRequest
            {
                SobaId = _sobaId.Value
            };
            var listaDodatnihUsluga = await _apiDodatneUslugeSobe.Get<List<Model.DodatnaUslugaSoba>>(request);
            dgvDodatneUsluge.AutoGenerateColumns = false;
            dgvDodatneUsluge.DataSource = listaDodatnihUsluga;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            txtCijenaDodatneUsluge.Enabled = false;
            var validationResult = ValidateChildren(ValidationConstraints.Enabled);
            txtCijenaDodatneUsluge.Enabled = true;
            if (!validationResult)
                return;

            Model.Requests.SobeInsertRequest request = new Model.Requests.SobeInsertRequest()
            {
                Naziv = txtNazivSobe.Text,
                BrojMalihKreveta = int.Parse(txtBrojMalihKreveta.Text),
                BrojVelikihKreveta = int.Parse(txtBrojVelikihKreveta.Text),
                VelicinaSobe = int.Parse(txtVelicinaSobe.Text),
                Cijena = double.Parse(txtCijena.Text),
                SmjestajId=CallerForm.SmjestajId
            };
            Model.Soba entity;
            if (_sobaId != null)
            {
                entity = await _apiServiceSobe.Update<Model.Soba>(_sobaId.Value, request);
            }
            else
            {
                entity = await _apiServiceSobe.Insert<Model.Soba>(request);

            }
            if (entity != null)
            {
                await CallerForm.RefreshSobe();
                MessageBox.Show("Uspješno ste uredili sobu!");
            }
            Close();
        }

        private void txtNazivSobe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivSobe.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNazivSobe, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtNazivSobe, null);
            }
        }

        private void txtBrojMalihKreveta_Validating(object sender, CancelEventArgs e)
        {
            int value;
            if(!int.TryParse(txtBrojMalihKreveta.Text, out value) || value<0 || value>10)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojMalihKreveta, string.Format(Properties.Resources.Validation_NotInRange, 0, 10));
            }
            else
            {
                errorProvider.SetError(txtBrojMalihKreveta, null);
            }
        }

        private void txtBrojVelikihKreveta_Validating(object sender, CancelEventArgs e)
        {
            int value;
            if (!int.TryParse(txtBrojVelikihKreveta.Text, out value) || value < 0 || value > 5)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojVelikihKreveta, string.Format(Properties.Resources.Validation_NotInRange, 0, 5));
            }
            else
            {
                errorProvider.SetError(txtBrojVelikihKreveta, null);
            }
        }

        private void txtVelicinaSobe_Validating(object sender, CancelEventArgs e)
        {
            int value;
            if (!int.TryParse(txtVelicinaSobe.Text, out value) || value < 4 || value > 250)
            {
                e.Cancel = true;
                errorProvider.SetError(txtVelicinaSobe, string.Format(Properties.Resources.Validation_NotInRange, 4, 250));
            }
            else
            {
                errorProvider.SetError(txtVelicinaSobe, null);
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

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            txtNazivSobe.Enabled = false;
            txtBrojMalihKreveta.Enabled = false;
            txtBrojVelikihKreveta.Enabled = false;
            txtVelicinaSobe.Enabled = false;
            txtCijena.Enabled = false;

            var validationResult = ValidateChildren(ValidationConstraints.Enabled);

            txtNazivSobe.Enabled = true;
            txtBrojMalihKreveta.Enabled = true;
            txtBrojVelikihKreveta.Enabled = true;
            txtVelicinaSobe.Enabled = true;
            txtCijena.Enabled = true;

            if (!validationResult)
                return;

            Model.Requests.DodatneUslugeSobeInsertRequest request = new Model.Requests.DodatneUslugeSobeInsertRequest
            {
                Cijena = float.Parse(txtCijenaDodatneUsluge.Text),
                SobaId = _sobaId.Value,
                DodatnaUslugaId = ((Model.DodatnaUsluga)cmbDodatneUsluge.SelectedItem).DodatnaUslugaId
            };

            var entity = await _apiDodatneUslugeSobe.Insert<Model.DodatnaUslugaSoba>(request);
            if(entity != null)
            {
                MessageBox.Show("Dodatna usluga uspješno dodana.");
                await RefreshDodatneUslugeSobe();
            }
        }

        private void txtCijenaDodatneUsluge_Validating(object sender, CancelEventArgs e)
        {

            double value;
            if (!double.TryParse(txtCijenaDodatneUsluge.Text, out value) || value < 0.1)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijenaDodatneUsluge, string.Format(Properties.Resources.Validation_MinValue, 0.1));
            }
            else
            {
                errorProvider.SetError(txtCijenaDodatneUsluge, null);
            }
        }

        private void btnUrediGaleriju_Click(object sender, EventArgs e)
        {
            var frm = new frmSobaSlike(_sobaId.Value);
            this.Hide();
            frm.Location = this.Location;


            if (CallerForm.CallerForm is frmSmjestaji frmSmjestaji1)
            {
                frmSmjestaji1.FrmMain.UpdateSizeAndLocation(frm);
            }
            if (CallerForm.CallerForm is frmDodajSmjestaj frmDodajSmjestaj1)
            {
                frmDodajSmjestaj1.FrmMain.UpdateSizeAndLocation(frm);
            }

            frm.ShowDialog();
            this.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUrediSobu_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

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

        private void cmbDodatneUsluge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }

        private void frmUrediSobu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 4),
                         this.DisplayRectangle);
        }
    }
}
