using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMef.Attributes;

namespace ConsoleMef
{
    [Export]
    public class LoggerTest
    {
        [LogImport("Header")]
        public ILogger TraceLogger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public void WriteLog()
        {
            TraceLogger.WriteInfo("LoggerTest");
        }
    }
}
