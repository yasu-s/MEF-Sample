using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;

namespace ConsoleMef2
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Property)]
    public class LogImportAttribute : ImportAttribute
    {
        public LogImportAttribute(string logType) : base()
        {
            LogType = logType;
        }

        public string LogType
        {
            get;
            private set;
        }

    }
}
