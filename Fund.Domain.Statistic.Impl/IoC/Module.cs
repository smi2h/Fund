using Microsoft.Practices.Unity;

namespace Fund.Domain.Statistic.Impl.IoC
{
    public static class Module
    {
        public static IUnityContainer WithStockStatisticServices(this IUnityContainer container)
        {
            return container.RegisterType<IStockStatisticService, StockStatisticService>();
        }
    }
}
