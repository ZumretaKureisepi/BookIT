using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookIT.Model.Requests
{
    public class KorisniciRegistracijaRequest
    {


        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(6)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PasswordPotvrda { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Adresa { get; set; }
        [Required]
        public int GradId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression("\\+?[0-9]{9,15}")]
        public string BrojMobitela { get; set; }

        [Required]
        public string UlogaIme { get; set; }

    }
}
