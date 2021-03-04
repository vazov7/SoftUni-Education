using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {

        public string BrowseInWorldWideWeb(string URL)
        {
           
            //Browsing: {site}!
            if (URL.Any(x => char.IsDigit(x)))
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {URL}!";
            }

        }

        public string CallOtherPhones(string number)
        {
            

            if (number.Any(x => !char.IsDigit(x)))
            {
                return "Invalid number!";
            }
            else
            {
                return $"Calling... {number}";
            }
        }
    }
}
