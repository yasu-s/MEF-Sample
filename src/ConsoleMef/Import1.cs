using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    [Export]
    public class Import1
    {

        [Import("test")]
        public ITest1 Ex1
        {
            get;
            set;
        }

        [Import("test")]
        public ITest2 Ex2
        {
            get;
            set;
        }

        public void Execute()
        {
            Ex1.Execute();
            Ex2.Execute();
        }
    }
}
