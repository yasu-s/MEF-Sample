using System;
using System.Collections.Generic;
using System.Composition;
using System.Composition.Hosting;
using System.Composition.Hosting.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef2
{
    /// <summary>
    /// 
    /// </summary>
    public class LogExportDescriptorProvider : ExportDescriptorProvider
    {
        /// <summary>
        /// <see cref="ILogger"/>生成処理
        /// 
        /// https://mef.codeplex.com/wikipage?title=ProgrammingModelExtensions&referringTitle=Documentation
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="descriptorAccessor"></param>
        /// <returns></returns>
        public override IEnumerable<ExportDescriptorPromise> GetExportDescriptors(CompositionContract contract, DependencyAccessor descriptorAccessor)
        {
            if (contract.ContractType == typeof(ILogger))
            {
                string value = string.Empty;
                CompositionContract unwrap;

                contract.TryUnwrapMetadataConstraint("LogType", out value, out unwrap);

                string header = string.Format("[{0}] LogExportDescriptorProvider - ", value);

                return new ExportDescriptorPromise[]
                {
                    new ExportDescriptorPromise(
                        contract,
                        "ConsoleMef2 ILogger",
                        true,
                        NoDependencies,
                        _ => ExportDescriptor.Create((c, o) => new Logger() { Header = header },  NoMetadata)
                    )
                };
            }
            else
                return NoExportDescriptors;
        }
    }
}
