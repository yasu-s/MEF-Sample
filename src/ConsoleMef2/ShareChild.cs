using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;

namespace ConsoleMef2
{
    [Export, Shared(Scope.Request)]
    public class ShareChild
    {
        public string Memo
        {
            get;
            set;
        }
    }
}
