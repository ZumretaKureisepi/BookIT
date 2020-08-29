using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Fakture
{
    public partial class frmFakturaDetalji : Form
    {
        private readonly APIService _apiServiceFakture = new APIService("Fakture");
        private readonly APIService _apiServiceDodatneUslugeRezervacije = new APIService("DodatneUslugeRezervacije");
        private readonly APIService _apiServiceSobeRezervacije = new APIService("SobeRezervacije");

        public int _fakturaId { get; set; }
        public frmFakturaDetalji(int FakturaId)
        {
            _fakturaId = FakturaId;
            InitializeComponent();
        }

        private async void frmFakturaDetalji_Load(object sender, EventArgs e)
        {

            var resultFakture = await _apiServiceFakture.GetById<Model.Faktura>(_fakturaId);

            this.Text = resultFakture.BrojFakture;
            lblNazivSmjestaja.Text = resultFakture.Rezervacija.Smjestaj.Naziv;
            lblDatumFakture.Text = resultFakture.DatumFakture.ToLongDateString();
            lblImeKlijenta.Text = resultFakture.ImePrezimeKlijent;
            lblAdresaKlijenta.Text = resultFakture.Rezervacija.Klijent.Korisnik.Adresa;
            lblLokacijaKlijent.Text = resultFakture.Rezervacija.Klijent.Korisnik.Grad.ToString();
            lblImeVlasnikaSmjestaja.Text = resultFakture.Rezervacija.Smjestaj.VlasnikSmjestaja.ToString();
            lblAdresaVlasnikaSmjestaja.Text = resultFakture.Rezervacija.Smjestaj.VlasnikSmjestaja.Korisnik.Adresa;
            lblLokacijaVlasnikSmjestaj.Text = resultFakture.Rezervacija.Smjestaj.VlasnikSmjestaja.Korisnik.Grad.ToString();

            bool IsApartman = false;

            switch (resultFakture.Rezervacija.Smjestaj.TipSmjestaja)
            {
                case Model.TipSmjestaja.Apartman:
                case Model.TipSmjestaja.Vila:
                case Model.TipSmjestaja.Kuca:
                    IsApartman = true;
                    break;
                default:
                    IsApartman = false;
                    break;
            }

            var search = new Model.Requests.DodatneUslugeRezervacijeSearchRequest()
            {
                RezervacijaId = resultFakture.RezervacijaId
            };


            var resultDodatneUslugeRezervacije = await _apiServiceDodatneUslugeRezervacije.Get<List<Model.DodatnaUslugaRezervacija>>(search);

            var Stavke = new List<Model.DodatnaUslugaRezervacija>();

            if (IsApartman)
            {
                Stavke.Add(new Model.DodatnaUslugaRezervacija
                {
                    DodatnaUsluga = new Model.DodatnaUsluga
                    {
                        Naziv = resultFakture.Rezervacija.Smjestaj.Naziv,

                    },
                    Cijena = resultFakture.Rezervacija.Smjestaj.Cijena.Value
                });

                foreach (var usluga in resultDodatneUslugeRezervacije)
                {
                    Stavke.Add(new Model.DodatnaUslugaRezervacija
                    {
                        DodatnaUsluga = new Model.DodatnaUsluga
                        {
                            Naziv = usluga.DodatnaUsluga.Naziv,
                        },
                        Cijena = usluga.Cijena
                    });
                }
            }
            else
            {

                var resultSobeRezervacije = await _apiServiceSobeRezervacije.Get<List<Model.SobaRezervacija>>(search);

                foreach (Model.SobaRezervacija soba in resultSobeRezervacije)
                {
                    Stavke.Add(new Model.DodatnaUslugaRezervacija
                    {
                        DodatnaUsluga = new Model.DodatnaUsluga
                        {
                            Naziv = soba.Soba.Naziv
                        },
                        Cijena = soba.Cijena
                    });

                    foreach (var usluga in resultDodatneUslugeRezervacije)
                    {
                        if (usluga.SobaId == soba.SobaId)
                        {
                            Stavke.Add(new Model.DodatnaUslugaRezervacija
                            {
                                DodatnaUsluga = new Model.DodatnaUsluga
                                {
                                    Naziv = usluga.DodatnaUsluga.Naziv,
                                },
                                Cijena = usluga.Cijena
                            });
                        }
                    }
                }

            }

            dgvDetaljiFakture.AutoGenerateColumns = false;
            dgvDetaljiFakture.DataSource = Stavke;

            double NumOfDays = Math.Ceiling((resultFakture.Rezervacija.CheckOutDate - resultFakture.Rezervacija.CheckInDate).TotalDays);

            Stavke.ForEach(x => { x.Cijena *= NumOfDays; });

            double Cijena = Stavke.Sum(x => x.Cijena);

            lblUkupanIznos.Text = Cijena.ToString("0.00") + " KM";

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFakturaDetalji_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }


    }
}
