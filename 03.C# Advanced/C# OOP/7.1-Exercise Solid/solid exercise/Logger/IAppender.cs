using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface IAppender 
    {
        void Append(string date, string reportlevel, string message);
    }
}
