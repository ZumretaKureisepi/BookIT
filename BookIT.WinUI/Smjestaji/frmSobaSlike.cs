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
    public partial class frmSobaSlike : Form
    {
        private readonly APIService _serviceSobeSlike = new APIService("SobeSlike");
        private int _sobaId { get; set; }//geter nije ovdje zato sto je privatni atribut i moze mu pristupiti samo isti objekat
        Model.Requests.SobeSlikeInsertRequest request = new Model.Requests.SobeSlikeInsertRequest();

        public frmSobaSlike(int SobaId)
        {
            _sobaId = SobaId;
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
            request.SobaId = _sobaId;
            request.Opis = txtOpisSlike.Text;

            var entity = await _serviceSobeSlike.Insert<Model.SobaSlika>(request);
            await BindForm();

        }

        private async void frmSobeSlike_Load(object sender, EventArgs e)
        {
            await BindForm();

        }

        private async Task BindForm()
        {
            var request = new Model.Requests.SobeSlikeSearchRequest
            {
                SobaId = _sobaId
            };

            dgvSlike.AutoGenerateColumns = false;
            dgvSlike.DataSource = await _serviceSobeSlike.Get<List<Model.SobaSlika>>(request);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSobaSlike_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }
    }
}
