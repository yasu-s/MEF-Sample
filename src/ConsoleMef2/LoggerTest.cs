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
        /// <summary>
        /// <see cref="ImportingConstructorAttribute"/>テスト1
        /// </summary>
        [Import]
        [ImportMetadataConstraint("LogType", "Trace")]
        public ILogger TraceLogger
        {
            get; set;
        }

        /// <summary>
        /// <see cref="ImportingConstructorAttribute"/>テスト2
        /// </summary>
        [Import]
        [ImportMetadataConstraint("LogType", "Error")]
        public ILogger ErrorLogger
        {
            get; set;
        }

        /// <summary>
        /// <see cref="LogImportAttribute"/>テスト
        /// </summary>
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
        /// <see cref="OnImportsSatisfiedAttribute"/>テスト <br/>
        /// Import完了時に実行されます。
        /// </summary>
        [OnImportsSatisfied]
        public void OnImportsSatisfied()
        {
            DebugLogger.WriteInfo("LoggerTest - OnImportsSatisfied");
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
