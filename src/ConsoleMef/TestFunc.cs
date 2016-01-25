using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    public class TestFunc
    {
        [Import("test")]
        public ITest1 Test
        {
            get;
            set;
        }


        [Export("testFunc")]
        public void Execute()
        {
            Test.Execute();
        }
    }
}
