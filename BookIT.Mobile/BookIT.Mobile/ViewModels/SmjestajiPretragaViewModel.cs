using BookIT.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookIT.Mobile.ViewModels
{
    public class SmjestajiPretragaViewModel: BaseViewModel
    {
        private readonly APIService _dodatneUslugeService = new APIService("DodatneUsluge");

        public SmjestajiPretragaViewModel()
        {
            Title = "Filtriranje smještaja";

            InitFormCommand = new Command(async () => await InitForm());
            InitFormCommand.Execute(null);
        }

        private async Task InitForm()
        {
            var listUsluge = await _dodatneUslugeService.Get<List<Model.DodatnaUsluga>>(null);
            DodatneUslugeList.Clear();
            foreach (var item in listUsluge)
            {
                DodatneUslugeList.Add(new Models.DodatnaUslugaSwitchCellItem
                {
                    Checked = false,
                    DodatnaUslugaId = item.DodatnaUslugaId,
                    Naziv = item.Naziv
                });
            }
        }

        public ObservableCollection<Models.DodatnaUslugaSwitchCellItem> DodatneUslugeList { get; set; } = new ObservableCollection<Models.DodatnaUslugaSwitchCellItem>();

        public ICommand InitFormCommand { get; set; }

        private bool _hoteli;
        public bool Hoteli
        {
            get { return _hoteli; }
            set { SetProperty(ref _hoteli, value); }
        }

        private bool _apartmani;
        public bool Apartmani
        {
            get { return _apartmani; }
            set { SetProperty(ref _apartmani, value); }
        }

        private bool _hosteli;
        public bool Hosteli
        {
            get { return _hosteli; }
            set { SetProperty(ref _hosteli, value); }
        }

        private bool _vile;
        public bool Vile
        {
            get { return _vile; }
            set { SetProperty(ref _vile, value); }
        }

        private bool _kuce;
        public bool Kuce
        {
            get { return _kuce; }
            set { SetProperty(ref _kuce, value); }
        }

        private bool _moteli;
        public bool Moteli
        {
            get { return _moteli; }
            set { SetProperty(ref _moteli, value); }
        }

        private bool _neocjenjeni;
        public bool Neocjenjeni
        {
            get { return _neocjenjeni; }
            set { SetProperty(ref _neocjenjeni, value); }
        }

        private bool _jednaZvjezdica;
        public bool JednaZvjezdica
        {
            get { return _jednaZvjezdica; }
            set { SetProperty(ref _jednaZvjezdica, value); }
        }

        private bool _dvijeZvjezdice;
        public bool DvijeZvjezdice
        {
            get { return _dvijeZvjezdice; }
            set { SetProperty(ref _dvijeZvjezdice, value); }
        }

        private bool _triZvjezdice;
        public bool TriZvjezdice
        {
            get { return _triZvjezdice; }
            set { SetProperty(ref _triZvjezdice, value); }
        }

        private bool _cetiriZvjezdice;
        public bool CetiriZvjezdice
        {
            get { return _cetiriZvjezdice; }
            set { SetProperty(ref _cetiriZvjezdice, value); }
        }

        private bool _petZvjezdica;
        public bool PetZvjezdica
        {
            get { return _petZvjezdica; }
            set { SetProperty(ref _petZvjezdica, value); }
        }

    }
}
