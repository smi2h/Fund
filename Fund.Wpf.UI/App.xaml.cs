using System.Windows; 
using Fund.DataLayer.Stock.IoC;
using Fund.Services.IoC;
using Fund.Wpf.ViewModels.Impl.IoC;
using Fund.Domain.Statistic.Impl.IoC;
using Microsoft.Practices.Unity;

namespace Fund.Wpf.UI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IUnityContainer container = new UnityContainer();
            container.WithStockServices();
            container.WithViewModelsServices();
            container.WithStockRepository();
            container.WithStockStatisticServices();

            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
