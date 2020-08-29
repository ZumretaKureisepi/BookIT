using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookIT.WinUI.Helpers
{
    public class ValidationHelper
    {
        public static bool IsValidEmailAddress(string email)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-šđčćž]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            if (reg.IsMatch(email))
                return true;

            return false;
        }

        public static bool IsValidPassword(string password)
        {
            Regex regLetters = new Regex(@"[A-Za-z]");
            Regex regNumbers = new Regex(@"[0-9]");
            if (regLetters.IsMatch(password) && regNumbers.IsMatch(password))
                return true;

            return false;
        }

        public static bool IsAlphabetic(string str)
        {
            Regex reg = new Regex(@"^[A-Z \-šđčćž]+$", RegexOptions.IgnoreCase);
            if (reg.IsMatch(str))
                return true;

            return false;
        }
        public static bool IsValidPhoneNumber(string str)
        {
            Regex reg = new Regex(@"^[0-9]{11,12}$");
            if (reg.IsMatch(str))
                return true;

            return false;
        }


    }
}
