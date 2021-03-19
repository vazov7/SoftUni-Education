﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shapes
    {
        public  abstract double CalculatePerimeter();
        public  abstract double CalculateArea();

        public virtual string Draw()
        {
            return "";
        }
    }
}
