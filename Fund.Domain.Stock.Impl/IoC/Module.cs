using Fund.Domain.Stock;
using Microsoft.Practices.Unity;

namespace Fund.Services.IoC
{
    public static class Module
    {
        public static IUnityContainer WithStockServices(this IUnityContainer container)
        {
            return container
                .RegisterType<IStockService, StockService>()
                .RegisterType<IStockBuilder, StockBuilder>();
        }
    }
}
