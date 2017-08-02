using System.Linq;
using Fund.DataLayer.Stock;
using Fund.DataLayer.Stock.Entities;
using Fund.Domain.Stock;

namespace Fund.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IStockBuilder _stockBuilder;

        public StockService(IStockRepository stockRepository, IStockBuilder stockBuilder)
        {
            _stockRepository = stockRepository;
            _stockBuilder = stockBuilder;
        }

        public Stock AddStock(StockType type, decimal price, int quantity)
        {
            var nextNumber = _stockRepository.GetStocks().Where(x=>x.Type == type).Max(x => x.Number) + 1;
            var newStock = _stockBuilder.Build(type, price, quantity, nextNumber);

            _stockRepository.AddStocks(newStock);
            return newStock;
        }

        public Stock[] GetStocks()
        {
            return _stockRepository.GetStocks();
        }
    }
}
