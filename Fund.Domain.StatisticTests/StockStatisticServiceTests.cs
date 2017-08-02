using System.Linq;
using FluentAssertions;
using Fund.DataLayer.Stock;
using Fund.DataLayer.Stock.Entities;
using Fund.Domain.Statistic.Impl;
using Fund.Domain.Statistic.Models;
using Moq;
using NUnit.Framework;

namespace Fund.Domain.StatisticTests
{
    public class StockStatisticServiceTests
    {
        private readonly Mock<IStockRepository> _stockRepository;
        private readonly StockStatisticService _stockStatisticService;
        
        public   StockStatisticServiceTests()
        {
          _stockRepository = new Mock<IStockRepository>(MockBehavior.Strict);
         _stockStatisticService = new StockStatisticService(_stockRepository.Object);
        }

        [Test]
        public void GetStatistic_CheckCalculations()
        {
            var bonds = new[]
            {
                (Stock) new Bond {Number = 10, Price = 100000, Quantity = 100},
                (Stock) new Bond {Number = 50, Price = 500000, Quantity = 500}
            };

            var equiteis = new[]
            {
                (Stock) new Equity {Number = 10, Price = 100000, Quantity = 100},
                (Stock) new Equity {Number = 50, Price = 500000, Quantity = 500}
            };

            var stocks = bonds.Union(equiteis).ToArray();

            var expected = new StockStatistic
            {
                BondTotalNumber = 600,
                BondTotalMarketValue = 260000000,
                BondTotalStockWeight = 0.5m,

                EquityTotalNumber = 600,
                EquityTotalMarketValue = 260000000,
                EquityTotalStockWeight = 0.5m,

                AllTotalNumber = 1200,
                AllTotalStockWeight = 1,
                AllTotalMarketValue = 520000000
            };

            _stockRepository.Setup(x => x.GetStocks()).Returns(stocks).Verifiable();

            var actual = _stockStatisticService.GetStatistic();

            actual.ShouldBeEquivalentTo(expected);
            _stockRepository.VerifyAll();
        }
    }
}
