﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IStationaryPhone
    {
        public abstract string CallOtherPhones(string number);
        
    }
}
