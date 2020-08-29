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
    public partial class frmDodajSobu : Form
    {
        private readonly APIService _apiServiceSobe = new APIService("Sobe");
        private frmSmjestajDetaljiSobe _frm { get; set; }
        private int? _sobaId { get; set; }
        public frmDodajSobu(frmSmjestajDetaljiSobe frm,int? SobaId=null)
        {
            _sobaId = SobaId;
            _frm = frm;
            InitializeComponent();
        }

        private async void frmDodajSobu_Load(object sender, EventArgs e)
        {
            if (_sobaId != null)
            {
                var entity = await _apiServiceSobe.GetById<Model.Soba>(_sobaId.Value);//pohranimo objekt u varijablu da bismo mogli izvuci atribute

                txtNazivSobe.Text = entity.Naziv;
                txtBrojMalihKreveta.Text = entity.BrojMalihKreveta.ToString();
                txtBrojVelikihKreveta.Text = entity.BrojVelikihKreveta.ToString();
                txtVelicinaSobe.Text = entity.VelicinaSobe.ToString();
                txtCijena.Text = entity.Cijena.ToString("0.00");
            }



        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
                return;

            Model.Requests.SobeInsertRequest request = new Model.Requests.SobeInsertRequest()
            {
                Naziv = txtNazivSobe.Text,
                BrojMalihKreveta = int.Parse(txtBrojMalihKreveta.Text),
                BrojVelikihKreveta = int.Parse(txtBrojVelikihKreveta.Text),
                VelicinaSobe = int.Parse(txtVelicinaSobe.Text),
                Cijena = double.Parse(txtCijena.Text),
                SmjestajId=_frm.SmjestajId
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
                await _frm.RefreshSobe();
                MessageBox.Show("Uspješno ste dodali novu sobu!");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDodajSobu_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

     
    }
}
