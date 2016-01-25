using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows;

namespace WpfMef.Util
{
    /// <summary>
    /// 
    /// </summary>
    public class MvvmFactory
    {

        private CompositionContainer container = null;

        /// <summary>
        /// 
        /// </summary>
        private MvvmFactory()
        {
            container = CreateContainer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static MvvmFactory GetInstanse()
        {
            return new MvvmFactory();
        }

        /// <summary>
        /// Container生成
        /// </summary>
        /// <returns></returns>
        private CompositionContainer CreateContainer()
        {
            var catalog = new AggregateCatalog();
            
            // 現在実行中のアセンブリフォルダからカタログを作成
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));

            // 現在実行中のアセンブリのカタログを元にコンテナを作る
            return new CompositionContainer(catalog);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Window CreateView(string name)
        {
            return container.GetExportedValue<Window>(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public INotifyPropertyChanged CreateViewModel(string name)
        {
            return container.GetExportedValue<INotifyPropertyChanged>(name);
        }

    }
}
