using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;

namespace ConsoleMef2
{
    [Export]
    public class ShareParent
    {
        [Import]
        public ShareChild Child
        {
            get;
            set;
        }
    }
}
