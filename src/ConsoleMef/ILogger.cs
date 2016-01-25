using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    public interface ILogger
    {
        string Header
        {
            get;
            set;
        }

        void WriteInfo(string msg);
    }
}
