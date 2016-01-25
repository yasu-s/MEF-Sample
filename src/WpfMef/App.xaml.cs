using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfMef.Util;

namespace WpfMef
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MvvmFactory factory = MvvmFactory.GetInstanse();

            Window view = factory.CreateView("Main");
            view.DataContext = factory.CreateViewModel("Main");

            view.Show();
        }
    }
}
