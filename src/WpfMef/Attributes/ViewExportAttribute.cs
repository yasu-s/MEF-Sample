using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMef.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class ViewExportAttribute : ExportAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public ViewExportAttribute(string name) : base(name, typeof(System.Windows.Window))
        {
        }
    }
}
