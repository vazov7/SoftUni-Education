using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public abstract class Appender : IAppender
    {
        private ILayout layout;
        protected Appender(ILayout layout)
        {
            this.layout = layout;
        }
        public abstract void Append(string date,string reportLevel,string message)
        {
            string content = string.Format()
        }
    }
}
