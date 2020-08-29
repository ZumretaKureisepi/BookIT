using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Drzave
{
    public partial class frmDrzave : Form
    {
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        public frmDrzave()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
            Model.Requests.DrzaveInsertRequest request = new Model.Requests.DrzaveInsertRequest
            {
                Naziv = txtDrzaveNaziv.Text
            };
            var entity = await _serviceDrzave.Insert<Model.Drzava>(request);

            if (entity != null)
            {
                BindForm();
                txtDrzaveNaziv.Text = "";
            }

        }

        private async void BindForm()
        {
            var listDrzave = await _serviceDrzave.Get<List<Model.Drzava>>(null);
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.DataSource = listDrzave;
        }

        private void frmDrzave_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void txtDrzaveNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDrzaveNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDrzaveNaziv, Properties.Resources.Validation_RequiredField);
            }
            else
                errorProvider.SetError(txtDrzaveNaziv, null);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDrzave_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void frmDrzave_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 4),
                         this.DisplayRectangle);
        }
    }
}
