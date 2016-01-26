using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Composition;
using System.Composition.Hosting;
using System.Composition.Convention;

namespace ConsoleMef2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var container = GetContainer();

                Test1(container);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// <see cref="CompositionContext"/>生成
        /// </summary>
        /// <returns></returns>
        private static CompositionContext GetContainer()
        {
            var config = new ContainerConfiguration();
            config.WithAssembly(typeof(Program).Assembly);

            //var builder = new ConventionBuilder();
            //builder.ForType<Logger>().Export<ILogger>();
            //config.WithAssembly(typeof(Program).Assembly, builder);

            config.WithProvider(new LogExportDescriptorProvider());

            return config.CreateContainer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        private static void Test1(CompositionContext container)
        {
            var test = container.GetExport<LoggerTest>();
            test.WriteLog();
        }
    }
}
