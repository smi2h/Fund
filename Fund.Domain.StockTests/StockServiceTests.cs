using Fund.DataLayer.Stock;
using Fund.DataLayer.Stock.Entities;
using Fund.Services;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Fund.Domain.StockTests
{
    public class StockServiceTests
    {
        private readonly Mock<IStockRepository> _stockRepository;
        private readonly Mock<IStockBuilder> _stockBuilder;
        private readonly StockService _stockService;

        public StockServiceTests()
        {
            _stockRepository = new Mock<IStockRepository>(MockBehavior.Strict);
            _stockBuilder = new Mock<IStockBuilder>(MockBehavior.Strict);
            _stockService = new StockService(_stockRepository.Object, _stockBuilder.Object);
        }

        [Test]
        public void GetStocks_ReturnItems()
        {
            var expected = new[]
            {
                new Bond {Number = 10, Price = 100000, Quantity = 100}
            };
            _stockRepository.Setup(x => x.GetStocks()).Returns(expected).Verifiable();

            var actual = _stockService.GetStocks();

            actual.ShouldBeEquivalentTo(expected);
            _stockRepository.VerifyAll();
        }

        [Test]
        public void AddStock_StockIsAdded()
        {
            var stocks = new[]
            {
                new Bond {Number = 10, Price = 100000, Quantity = 100}
            };

            var type = StockType.Bond;
            var price = 100;
            var quantity = 10;

            var expected = new Bond
            {
                Number = 11,
                Price = price,
                Quantity = quantity
            };

            _stockRepository.Setup(x => x.GetStocks()).Returns(stocks).Verifiable();
            _stockBuilder.Setup(x => x.Build(type, price, quantity, 11)).Returns(expected).Verifiable();
            _stockRepository.Setup(x => x.AddStocks(expected)).Verifiable();

            var actual = _stockService.AddStock(type, price, quantity);

            actual.ShouldBeEquivalentTo(expected);
            _stockRepository.VerifyAll();
            _stockBuilder.VerifyAll();
        }
    }
}
