using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef2
{
    public interface ILogger
    {
        string Header
        {
            get;
            set;
        }

        string Status
        {
            get;
            set;
        }
        
        void WriteInfo(string msg);
    }
}
