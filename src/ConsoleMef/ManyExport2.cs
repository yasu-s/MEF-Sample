using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    [Export(typeof(IManyTest))]
    public class ManyExport2 : IManyTest
    {
        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("ManyExport2");
        }
    }
}
