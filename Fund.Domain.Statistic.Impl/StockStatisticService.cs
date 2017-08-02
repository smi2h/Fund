using System.Linq;
using Fund.DataLayer.Stock;
using Fund.DataLayer.Stock.Entities;
using Fund.Domain.Statistic.Models;

namespace Fund.Domain.Statistic.Impl
{
    public class StockStatisticService : IStockStatisticService
    {
        private readonly IStockRepository _stockRepository;

        public StockStatisticService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public StockStatistic GetStatistic()
        {
            var stocks = _stockRepository.GetStocks();
            var totalMarketValue = stocks.Sum(p => p.Price * p.Quantity);
            var equities = stocks.Where(p => p.Type == StockType.Equity).ToArray();
            var bonds = stocks.Where(p => p.Type == StockType.Bond).ToArray();

            return new StockStatistic
            {
                AllTotalNumber = stocks.Sum(p => p.Quantity),
                AllTotalMarketValue = stocks.Sum(p => p.Price * p.Quantity),
                AllTotalStockWeight = stocks.Sum(p => p.Price * p.Quantity) / totalMarketValue,

                EquityTotalMarketValue = equities.Sum(p => p.Price * p.Quantity),
                EquityTotalNumber = equities.Sum(p => p.Quantity),
                EquityTotalStockWeight = equities.Sum(p => p.Price * p.Quantity ) / totalMarketValue,

                BondTotalNumber = bonds.Sum(p => p.Quantity),
                BondTotalMarketValue = bonds.Sum(p => p.Price * p.Quantity),
                BondTotalStockWeight = bonds.Sum(p => p.Price * p.Quantity) / totalMarketValue
            };
        }
    }
}
