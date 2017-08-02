using Fund.DataLayer.Stock.Entities; 

namespace Fund.Wpf.ViewModels
{
    public interface IStockFactory
    {
        StockViewModel Build(Stock stock, decimal totalMarketValue);
    }
}