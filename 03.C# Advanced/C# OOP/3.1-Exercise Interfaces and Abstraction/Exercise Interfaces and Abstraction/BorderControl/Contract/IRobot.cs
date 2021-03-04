using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IRobot:IPerson
    {
        public string Model { get; set; }
    }
}
