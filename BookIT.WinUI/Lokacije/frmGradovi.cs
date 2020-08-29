using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Lokacije
{
    public partial class frmGradovi : Form
    {
        private readonly APIService _serviceGradovi = new APIService("Gradovi");
        private readonly APIService _serviceDrzave = new APIService("Drzave");

        public frmGradovi()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
            int drzavaId =(cmbDrzava.SelectedItem as Model.Drzava).DrzavaId;
            var request = new Model.Requests.GradoviInsertRequest
            {
                DrzavaId = drzavaId,
                Naziv = txtGradNaziv.Text
            };
            await _serviceGradovi.Insert<Model.Grad>(request);
            BindForm();
            txtGradNaziv.Text = "";
        }

        private async void BindForm()
        {
            var listGradovi = await _serviceGradovi.Get<List<Model.Grad>>(null);
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.DataSource = listGradovi;
        }

        private async void frmGradovi_Load(object sender, EventArgs e)
        {
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.DataSource = await _serviceDrzave.Get<List<Model.Drzava>>(null);
            BindForm();
        }

        private void txtGradNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGradNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtGradNaziv, Properties.Resources.Validation_RequiredField);
            }
            else
                errorProvider.SetError(txtGradNaziv, null);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGradovi_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void cmbDrzava_Validating(object sender, CancelEventArgs e)
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

        private void cmbDrzava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }
    }
}
