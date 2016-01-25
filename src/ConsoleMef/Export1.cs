using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    [Export("test", typeof(ITest1))]
    public class Export1 : ITest1
    {
        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("Export1");
        }
    }
}
