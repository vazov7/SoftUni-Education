using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone : IStationaryPhone
    {
        public string BrowseInWorldWideWeb(string URL);
    }
}
