using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Rezervacije
{
    public partial class frmRezervacijeDetalji : Form
    {
        private readonly APIService _apiServiceRezervacije = new APIService("Rezervacije");
        private frmRezervacije ParentForm;

        private int _rezervacijaId { get; set; }
        public frmRezervacijeDetalji(int RezervacijaId, frmRezervacije frmRezervacije)
        {
            _rezervacijaId = RezervacijaId;
            ParentForm = frmRezervacije;

            InitializeComponent();
        }

        private async void frmRezervacijeDetalji_Load(object sender, EventArgs e)
        {
            var resultRezervacija = await _apiServiceRezervacije.GetById<Model.Rezervacija>(_rezervacijaId);
            await RezervacijaHelper.GetCijenaRezervacijeINaziveSoba(resultRezervacija);
            lblImeSmjestaja.Text = resultRezervacija.Smjestaj.ToString();
            lblImeSobe.Text = resultRezervacija.Sobe;
            lblDatumDolaska.Text = resultRezervacija.CheckInDate.ToLongDateString();
            lblDatumOdlaska.Text = resultRezervacija.CheckOutDate.ToLongDateString();
            lblImeKlijenta.Text = resultRezervacija.Klijent.ToString();
            lblAdresaKlijenta.Text = resultRezervacija.Klijent.Korisnik.Adresa;
            lblLokacija.Text = resultRezervacija.Klijent.Korisnik.Grad.ToString();
            lblCijena.Text = resultRezervacija.Cijena.ToString("0.00") + " KM";

            if (resultRezervacija.Status != Model.Rezervacija.eStanje.CekanjePotvrde)
            {
                //btnPrihvatiRezervaciju.Enabled = false;
                //btnOdbijRezervaciju.Enabled = false;
                btnPrihvatiRezervaciju.Visible = false;
                btnOdbijRezervaciju.Visible = false;
            }

        }

        private async void btnPrihvatiRezervaciju_Click(object sender, EventArgs e)
        {
            var resultRezervacija = await _apiServiceRezervacije.GetById<Model.Rezervacija>(_rezervacijaId);

            if (resultRezervacija.Status== Model.Rezervacija.eStanje.CekanjePotvrde) {

                resultRezervacija.Status = Model.Rezervacija.eStanje.CekanjeUplate;
                await _apiServiceRezervacije.Update<Model.Rezervacija>(resultRezervacija.RezervacijaId, resultRezervacija);
                //btnPrihvatiRezervaciju.Enabled = false;
                //btnOdbijRezervaciju.Enabled = false;
                btnPrihvatiRezervaciju.Visible = false;
                btnOdbijRezervaciju.Visible = false;
                await ParentForm.BindForm();
            }




        }

        private async void btnOdbijRezervaciju_Click(object sender, EventArgs e)
        {
            var resultRezervacija = await _apiServiceRezervacije.GetById<Model.Rezervacija>(_rezervacijaId);

            if (resultRezervacija.Status == Model.Rezervacija.eStanje.CekanjePotvrde)
            {

                resultRezervacija.Status = Model.Rezervacija.eStanje.Odbijena;
                await _apiServiceRezervacije.Update<Model.Rezervacija>(resultRezervacija.RezervacijaId, resultRezervacija);
                //btnPrihvatiRezervaciju.Enabled = false;
                //btnOdbijRezervaciju.Enabled = false;
                btnPrihvatiRezervaciju.Visible = false;
                btnOdbijRezervaciju.Visible = false;
                await ParentForm.BindForm();
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRezervacijeDetalji_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void frmRezervacijeDetalji_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 4),
                         this.DisplayRectangle);
        }
    }
}
