using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Smjestaji
{
    public partial class frmSmjestajSlike : Form
    {
        private readonly APIService _serviceSmjestajiSlike = new APIService("SmjestajiSlike");
        private int _smjestajId { get; set; }//geter nije ovdje zato sto je privatni atribut i moze mu pristupiti samo isti objekat
        Model.Requests.SmjestajiSlikeInsertRequest request = new Model.Requests.SmjestajiSlikeInsertRequest();

        public frmSmjestajSlike(int SmjestajId)
        {
            _smjestajId = SmjestajId;
            InitializeComponent();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;



                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            request.SmjestajId = _smjestajId;
            request.Opis = txtOpisSlike.Text;

            var entity = await _serviceSmjestajiSlike.Insert<Model.SmjestajSlika>(request);
            await BindForm();

        }

        private async void frmSmjestajSlike_Load(object sender, EventArgs e)
        {
            await BindForm();

        }

        private async Task BindForm()
        {
            var request = new Model.Requests.SmjestajiSlikeSearchRequest
            {
                SmjestajId = _smjestajId
            };

            dgvSlike.AutoGenerateColumns = false;
            dgvSlike.DataSource = await _serviceSmjestajiSlike.Get<List<Model.SmjestajSlika>>(request);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSmjestajSlike_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void frmSmjestajSlike_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 4),
                         this.DisplayRectangle);
        }
    }
}
