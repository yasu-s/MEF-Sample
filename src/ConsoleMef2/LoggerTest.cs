using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef2
{
    [Export]
    public class LoggerTest
    {
        [Import]
        [ImportMetadataConstraint("LogType", "Trace")]
        public ILogger TraceLogger
        {
            get; set;
        }

        [Import]
        [ImportMetadataConstraint("LogType", "Error")]
        public ILogger ErrorLogger
        {
            get; set;
        }

        [LogImport("Debug")]
        public ILogger DebugLogger
        {
            get; set;
        }

        [Import("test1")]
        public ITest Test1
        {
            get; set;
        }

        [Import("test2")]
        public ITest Test2
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public void WriteLog()
        {
            TraceLogger.WriteInfo(string.Format("LoggerTest {0}, {1}", Test1.GetName(), Test2.GetName()));
            ErrorLogger.WriteInfo("ErrorLoggerTest");
            DebugLogger.WriteInfo("LoggerTest");
        }
    }
}
