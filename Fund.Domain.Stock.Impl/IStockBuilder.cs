using Fund.DataLayer.Stock.Entities;

namespace Fund.Services
{
    public interface IStockBuilder
    {
        Stock Build(StockType type, decimal price, int quantity, int number);
    }
}