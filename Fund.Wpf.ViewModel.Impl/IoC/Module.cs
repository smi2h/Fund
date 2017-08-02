using Microsoft.Practices.Unity;

namespace Fund.Wpf.ViewModels.Impl.IoC
{
    public static class Module
    {
        public static IUnityContainer WithViewModelsServices(this IUnityContainer container)
        {
           return container
                .RegisterType<IStockFactory, StockFactory>()
                .RegisterType<IStockStatisticBuilder, StockStatisticBuilder>()
                .RegisterType<IFundViewModel, FundViewModel>();
        }
    }
}
