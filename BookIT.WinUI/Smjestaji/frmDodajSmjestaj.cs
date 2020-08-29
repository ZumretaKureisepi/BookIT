using BookIT.Model.Requests;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class frmDodajSmjestaj : MaterialForm
    {
        private readonly APIService _apiServiceSmjestaji = new APIService("Smjestaji");
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");

        public frmMain FrmMain { get; }
        public Form ChildForm { get; set; }

        public frmDodajSmjestaj(frmMain frmMain)
        {
            InitializeComponent();
       
            FrmMain = frmMain;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {

            SmjestajiInsertRequest request = new SmjestajiInsertRequest
            {
                Naziv = txtImeSmjestaja.Text,
                GradId = ((Model.Grad)cmbLokacije.SelectedItem).GradId,
                TipSmjestaja = (Model.TipSmjestaja)cmbTipSmjestaja.SelectedIndex
            };
            Model.Smjestaj entity = await _apiServiceSmjestaji.Insert<Model.Smjestaj>(request);
            if (entity != null)
            {

                Hide();

                Helpers.SmjestajHelper.EditSmjestaj(entity, this);

                Close();
            }
        }

        private async void frmDodajSmjestaj_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceGradovi.Get<List<Model.Grad>>(null);//zasto null ovdje
            cmbLokacije.ValueMember = "GradId";
            cmbLokacije.DisplayMember = "Grad_Drzava";
            cmbLokacije.DataSource = result;

            cmbTipSmjestaja.DataSource = Enum.GetValues(typeof(Model.TipSmjestaja));

        }

        private void txtImeSmjestaja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeSmjestaja.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtImeSmjestaja, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtImeSmjestaja, null);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodajSmjestaj_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);
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

        private void cmbLokacije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }
    }
}
