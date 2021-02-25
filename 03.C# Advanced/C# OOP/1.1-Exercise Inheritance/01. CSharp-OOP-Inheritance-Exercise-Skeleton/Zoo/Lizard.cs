using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Lizard : Reptile
    {
        public Lizard(string name)
            :base(name)
            
        {

        }

        public string Name { get; set; }

    }
}
