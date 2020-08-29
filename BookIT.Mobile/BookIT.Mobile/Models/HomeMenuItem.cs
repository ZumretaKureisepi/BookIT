using System;
using System.Collections.Generic;
using System.Text;

namespace BookIT.Mobile.Models
{
    public enum MenuItemType
    {
        PretragaSmjestaja,
        Rezervacija,
        Faktura,
        Profil,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
