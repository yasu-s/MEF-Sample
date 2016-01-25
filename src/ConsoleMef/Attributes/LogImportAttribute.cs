using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef.Attributes
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Property)]
    public class LogImportAttribute : ImportAttribute
    {

        public LogImportAttribute(string header) : base(typeof(ILogger))
        {
            Header = header;
        }

        public string Header
        {
            get;
            private set;
        }
    }
}
