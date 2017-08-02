using Microsoft.Practices.Unity;

namespace Fund.DataLayer.Stock.IoC
{
    public static class Module
    {
        public static IUnityContainer WithStockRepository(this IUnityContainer container)
        {
            return container
                .RegisterType<IStockRepository, StockRepository>();
        }
    }
}
