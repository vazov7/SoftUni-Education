using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone : IStationaryPhone
    {
        public abstract string BrowseInWorldWideWeb(string URL);
    }
}
