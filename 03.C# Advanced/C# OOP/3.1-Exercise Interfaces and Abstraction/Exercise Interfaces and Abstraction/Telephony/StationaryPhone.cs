using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {

        public string CallOtherPhones(string number)
        {
            

            if (number.Any(x => !char.IsDigit(x)))
            {
                return "Invalid number!";
            }
            else
            {
                return $"Dialing... {number}";
            }
        }
    }
}
