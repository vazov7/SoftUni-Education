using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface ILayout
    {
        string Template { get; }
    }
}
