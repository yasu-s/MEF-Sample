using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.ComponentModel.Composition.ReflectionModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
{
    public class LogExportProvider : ExportProvider
    {
        protected override IEnumerable<Export> GetExportsCore(ImportDefinition definition, AtomicComposition atomicComposition)
        {

            if (definition.ContractName.Equals(typeof(ILogger).FullName))
            {
                yield return new Export(definition.ContractName, () => new Logger() { Header = "Factory - " });
            }
        }
    }
}
