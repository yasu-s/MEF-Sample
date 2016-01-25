using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef
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
                Test3(container);
                Test4(container);
                Test5(container);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Container生成
        /// </summary>
        /// <returns></returns>
        private static CompositionContainer GetContainer()
        {
            var builder = new RegistrationBuilder();
            builder.ForType(typeof(ManualTest)).Export();

            var catalog = new AggregateCatalog();


            // 現在実行中のアセンブリフォルダからカタログを作成
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly(), builder));
            
            // 現在実行中のアセンブリのカタログを元にコンテナを作る
            return new CompositionContainer(catalog);
        }

        /// <summary>
        /// 同一コントラクト名・別クラステスト
        /// </summary>
        /// <param name="container"></param>
        private static void Test1(CompositionContainer container)
        {
            // インスタンスを取得する
            var type1 = container.GetExportedValue<ITest1>("test");
            var type2 = container.GetExportedValue<ITest2>("test");

            type1.Execute();
            type2.Execute();
        }

        /// <summary>
        /// Importテスト
        /// </summary>
        /// <param name="container"></param>
        private static void Test2(CompositionContainer container)
        {
            var type1 = container.GetExportedValue<Import1>();
            type1.Execute();
        }

        /// <summary>
        /// 複数インターフェイス取得
        /// </summary>
        /// <param name="container"></param>
        private static void Test3(CompositionContainer container)
        {
            var types = container.GetExportedValues<IManyTest>();
            foreach (IManyTest test in types)
            {
                test.Execute();
            }
        }

        /// <summary>
        /// メソッドExport
        /// </summary>
        /// <param name="container"></param>
        private static void Test4(CompositionContainer container)
        {
            var func = container.GetExport<Action>("testFunc");
            func.Value();
        }

        /// <summary>
        /// 手動Export
        /// </summary>
        /// <param name="container"></param>
        private static void Test5(CompositionContainer container)
        {
            var type1 = container.GetExportedValue<ManualTest>();
            type1.Execute();
        }
        
    }
}
