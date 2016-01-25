using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    [Export(typeof(IManyTest))]
    public class ManyExport1 : IManyTest, IPartImportsSatisfiedNotification
    {
        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("ManyExport1");
        }

        public void OnImportsSatisfied()
        {
            System.Diagnostics.Debug.WriteLine("ManyExport1 - OnImportsSatisfied");
        }
    }
}
