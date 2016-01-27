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
                Test2(container);
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

        /// <summary>
        /// SharingBoundary,Sharedテスト
        /// </summary>
        /// <param name="container"></param>
        private static void Test2(CompositionContext container)
        {
            var factory = container.GetExport<ShareFactory>();

            ShareTest test1, test2, test3;

            using (var ctx = factory.Factory.CreateExport())
            {
                if (container == ctx.Value)
                    System.Diagnostics.Debug.WriteLine("Container same");
                else
                    System.Diagnostics.Debug.WriteLine("Container not same");

                test1 = ctx.Value.GetExport<ShareTest>();

                if (test1.Child == test1.Parent.Child)
                    System.Diagnostics.Debug.WriteLine("Child same (test1-test1.Child)");
                else
                    System.Diagnostics.Debug.WriteLine("Child not same (test1-test1.Child)");

                test2 = ctx.Value.GetExport<ShareTest>();

                if (test1.Child == test2.Child)
                    System.Diagnostics.Debug.WriteLine("Child same (test1-test2)");
                else
                    System.Diagnostics.Debug.WriteLine("Child not same (test1-test2)");
            }

            using (var ctx = factory.Factory.CreateExport())
            {
                test3 = ctx.Value.GetExport<ShareTest>();

                if (test1.Child == test3.Child)
                    System.Diagnostics.Debug.WriteLine("Child same (test1-test3)");
                else
                    System.Diagnostics.Debug.WriteLine("Child not same (test1-test3)");

                var logger = ctx.Value.GetExport<LoggerTest>();
                logger.WriteLog();
            }
        }
    }
}
