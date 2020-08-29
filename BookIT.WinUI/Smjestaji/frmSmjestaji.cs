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
    public partial class frmSmjestaji : Form
    {
        private readonly APIService _apiServiceSmjestaji = new APIService("Smjestaji");

        public frmMain FrmMain { get; }
        public Form ChildForm { get; set; }

        public frmSmjestaji(frmMain frmMain)
        {
            InitializeComponent();
            this.close.Location = new Point(this.Width - 24, 5);
            FrmMain = frmMain;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await BindForm();
        }

        private async Task BindForm()
        {
            var search = new SmjestajiSearchRequest()
            {
                Naziv = txtPretraga.Text

            };
            var result = await _apiServiceSmjestaji.Get<List<Model.Smjestaj>>(search);
            dgvSmjestaji.AutoGenerateColumns = false;
            dgvSmjestaji.DataSource = result;
        }

        private async void dgvSmjestaji_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var SmjestajId = int.Parse(dgvSmjestaji.SelectedRows[0].Cells[0].Value.ToString());
            var entity = await _apiServiceSmjestaji.GetById<Model.Smjestaj>(SmjestajId);

            Helpers.SmjestajHelper.EditSmjestaj(entity, this);

        }



        private async void frmSmjestaji_Load(object sender, EventArgs e)
        {
            await BindForm();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSmjestaji_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await BindForm();
        }

        private void frmSmjestaji_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 4),
                         this.DisplayRectangle);
        }
    }
}
