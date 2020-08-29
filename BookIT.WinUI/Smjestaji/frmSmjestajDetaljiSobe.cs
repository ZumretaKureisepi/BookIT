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
    public partial class frmSmjestajDetaljiSobe : Form
    {
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        private readonly APIService _apiServiceSobe = new APIService("Sobe");
        private readonly APIService _apiServiceSmjestaji = new APIService("Smjestaji");

        private int _smjestajId { get; set; }
        public Form CallerForm { get; }
        public Form ChildForm { get; set; }

        public frmSmjestajDetaljiSobe(int SmjestajId, Form callerForm)
        {
            _smjestajId = SmjestajId;
            CallerForm = callerForm;
            InitializeComponent();
        }
        public int SmjestajId { get => _smjestajId; }
        public Smjestaj Smjestaj { get; private set; }

        private async void frmSmjestajDetaljiSobe_Load(object sender, EventArgs e)
        {
            Smjestaj = await _apiServiceSmjestaji.GetById<Model.Smjestaj>(_smjestajId);

            this.Text = Smjestaj.Naziv;
            lblNazivSmjestaja.Text = Smjestaj.Naziv;
           
            var result = await _apiServiceGradovi.Get<List<Model.Grad>>(null);//zasto null ovdje
            cmbLokacije.ValueMember = "GradId";
            cmbLokacije.DisplayMember = "Grad_Drzava";

            cmbTipSmjestaja.DataSource = Enum.GetValues(typeof(Model.TipSmjestaja));

            clbTipDestinacije.DataSource = Enum.GetValues(typeof(Model.TipDestinacije));

            lblLatitude.Text = Smjestaj.Latitude.ToString("0.00000");
            lblLongitude.Text = Smjestaj.Longitude.ToString("0.00000");

            for (int i = 0; i < clbTipDestinacije.Items.Count; i++)
            {
                foreach (var item in Smjestaj.SmjestajTipDestinacije)
                {
                    if (item.TipDestinacije == (clbTipDestinacije.Items[i] as Model.TipDestinacije?))
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
            await RefreshSobe();

            cmbTipSmjestaja.SelectedItem = Smjestaj.TipSmjestaja;
            txtAdresa.Text = Smjestaj.Adresa;
            txtOpis.Text = Smjestaj.Opis;

        }

        public async Task RefreshSobe()
        {
            var search = new SobeSearchRequest()
            {
                SmjestajId = _smjestajId
            };
            var result1 = await _apiServiceSobe.Get<List<Model.Soba>>(search);
            dgvSobe.AutoGenerateColumns = false;
            dgvSobe.DataSource = result1;
        }

       
        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            var validationResult = ValidateChildren(ValidationConstraints.Enabled);
            if (!validationResult)
                return;
            
            var resultSmjestaj = await _apiServiceSmjestaji.GetById<Model.Smjestaj>(_smjestajId);
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

  

        private void btnDodajSobu_Click(object sender, EventArgs e)
        {
            frmDodajSobu frm = new frmDodajSobu(this);
            ChildForm = frm;
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

        private void dgvSobe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sobaId = int.Parse(dgvSobe.SelectedRows[0].Cells[0].Value.ToString());

            frmUrediSobu frm = new frmUrediSobu(this, sobaId);
            ChildForm = frm;
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

        private void btnUrediGaleriju_Click(object sender, EventArgs e)
        {
            var frm = new frmSmjestajSlike(SmjestajId);
            ChildForm = frm;
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

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSmjestajDetaljiSobe_Resize(object sender, EventArgs e)
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
