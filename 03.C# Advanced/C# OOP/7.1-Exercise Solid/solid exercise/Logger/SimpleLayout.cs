using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class SimpleLayout : ILayout
    {
        
        public string Template => "{0} - {1} - {2}";
    }
}
