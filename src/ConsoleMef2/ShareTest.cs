using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;

namespace ConsoleMef2
{
    [Export]
    public class ShareTest
    {

        [Import]
        public ShareChild Child
        {
            get;
            set;
        }

        [Import]
        public ShareParent Parent
        {
            get;
            set;
        }

        public void Exec()
        {
            
        }
    }
}
