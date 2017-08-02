using FluentAssertions;
using Fund.DataLayer.Stock.Entities;
using Fund.Wpf.ViewModel;
using Fund.Wpf.ViewModels;
using Fund.Wpf.ViewModels.Impl;
using NUnit.Framework;

namespace Fund.Wpf.ViewModelTests
{
    public class StockFactoryTests
    {
        private readonly StockFactory _stockFactory;

        public StockFactoryTests()
        {
            _stockFactory = new StockFactory();
        }

        [Test]
        [TestCase(1000, 50, false)]
        [TestCase(100000, 5000, true)]
        [TestCase(2, -100, true)]
        public void Build_StockTypeIsBond_ReturnsCorrectBondViewModel(decimal price, int quantity, bool isHighlighted)
        {
            var bond = new Bond
            {
                Number = 100,
                Price = price,
                Quantity = quantity
            };
            var totalMarketValue = 50000;
            var expected = new BondViewModel
            {
                Type = StockType.Bond,
                IsHighlighted = isHighlighted,
                Name = "Bond100",
                Price = bond.Price,
                Quantity = bond.Quantity,
                MarketValue = bond.Price*bond.Quantity,
                TransactionCosts = (bond.Price*bond.Quantity)*0.02m,
                StockWeight = (bond.Price*bond.Quantity)/totalMarketValue
            };
            
            var actual = _stockFactory.Build(bond, totalMarketValue);
            actual.ShouldBeEquivalentTo(expected);
        }

        [Test]
        [TestCase(1000, 50, false)]
        [TestCase(100000, 5000, true)]
        [TestCase(2, -100, true)]
        public void Build_StockTypeIsEquity_ReturnsCorrectEquityViewModel(decimal price, int quantity, bool isHighlighted)
        {
            var bond = new Equity
            {
                Number = 100,
                Price = price,
                Quantity = quantity
            };
            var totalMarketValue = 50000;
            var expected = new EquityViewModel
            {
                Type = StockType.Equity,
                IsHighlighted = isHighlighted,
                Name = "Equity100",
                Price = bond.Price,
                Quantity = bond.Quantity,
                MarketValue = bond.Price * bond.Quantity,
                TransactionCosts = (bond.Price * bond.Quantity) * 0.005m,
                StockWeight = (bond.Price * bond.Quantity) / totalMarketValue
            };

            var actual = _stockFactory.Build(bond, totalMarketValue);
            actual.ShouldBeEquivalentTo(expected);
        }
    }
}
