﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef2
{
    public interface ITest
    {
        ILogger DebugLogger
        {
            get;
            set;
        }
        
        string GetName();
    }
}
