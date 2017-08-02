 using Fund.DataLayer.Stock.Entities;

namespace Fund.Domain.Stock
{
    public interface IStockService
    {
        DataLayer.Stock.Entities.Stock AddStock(StockType type, decimal price, int quantity);
        DataLayer.Stock.Entities.Stock[] GetStocks();
    }
}
