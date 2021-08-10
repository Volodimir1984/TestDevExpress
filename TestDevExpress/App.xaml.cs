using System.Collections.Generic;
using System.Collections.ObjectModel;
using Autofac;
using System.Windows;
using System.Windows.Documents;
using TestDevExpress.Interfaces;
using TestDevExpress.Models;
using TestDevExpress.ViewModels;

namespace TestDevExpress
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MarketStack>().AsSelf().As<IGetFinancesInfo>();
            builder.RegisterType<MainViewModel>().AsSelf();
            var container = builder.Build();
            var model = container.Resolve<MainViewModel>();
            var view = new MainWindow { DataContext = model };
            view.Show();
        }
    }
}
