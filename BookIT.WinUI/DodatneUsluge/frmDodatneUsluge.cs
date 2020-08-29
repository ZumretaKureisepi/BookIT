using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.DodatneUsluge
{
    public partial class frmDodatneUsluge : Form
    {
        private readonly APIService _serviceDodatneUsluge = new APIService("DodatneUsluge");
        public frmDodatneUsluge()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
            Model.Requests.DodatneUslugeInsertRequest request = new Model.Requests.DodatneUslugeInsertRequest
            {
                Naziv = txtUslugaNaziv.Text
            };
            var entity = await _serviceDodatneUsluge.Insert<Model.DodatnaUsluga>(request);

            if (entity != null)
            {
                txtUslugaNaziv.Text = "";
                BindForm();
            }

        }

        private async void BindForm()
        {
            var listUsluge = await _serviceDodatneUsluge.Get<List<Model.DodatnaUsluga>>(null);
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.DataSource = listUsluge;
        }

        private void frmDodatneUsluge_Load(object sender, EventArgs e)
        {

            BindForm();
        }

        private void txtUslugaNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUslugaNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUslugaNaziv, Properties.Resources.Validation_RequiredField);
            }
            else
                errorProvider.SetError(txtUslugaNaziv, null);

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodatneUsluge_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }
    }
}
