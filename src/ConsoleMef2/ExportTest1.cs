﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;

namespace ConsoleMef2
{
    [Export("test1", typeof(ITest))]
    public class ExportTest1 : ITest
    {
        [LogImport("Debug"), SharingBoundary("SharedTest")]
        public ILogger DebugLogger
        {
            get;
            set;
        }

        public string GetName()
        {
            return "ExportTest1";
        }
    }
}
