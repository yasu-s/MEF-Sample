using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;

namespace ConsoleMef2
{
    [Export]
    public class ShareFactory
    {
        [Import, SharingBoundary(Scope.Request, Scope.Session)]
        public ExportFactory<CompositionContext> Factory
        {
            get;
            set;
        }
    }
}
