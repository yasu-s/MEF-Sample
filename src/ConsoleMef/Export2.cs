using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    [Export("test", typeof(ITest2))]
    public class Export2 : ITest2
    {
        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("Export2");
        }
    }
}
