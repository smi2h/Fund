using System;
using Fund.DataLayer.Stock.Entities;
using Fund.Wpf.ViewModel;

namespace Fund.Wpf.ViewModels.Impl
{
    public class StockFactory : IStockFactory
    {
        public StockViewModel Build(Stock stock, decimal totalMarketValue)
        {
            if (stock == null)
                throw new NullReferenceException();

            var marketValue = stock.Price*stock.Quantity;

            switch (stock.Type)
            {
                case StockType.Bond:
                    var bondTransactionCosts = marketValue*0.02m;
                    var bondViewModel = new BondViewModel
                    {
                        MarketValue = marketValue,
                        TransactionCosts = bondTransactionCosts,
                        Name = $"{stock.Type}{stock.Number}",
                        IsHighlighted = marketValue < 0 || bondTransactionCosts > 100000,
                        StockWeight = marketValue/totalMarketValue
                    };
                    FillStock(bondViewModel, stock);
                    return bondViewModel;

                case StockType.Equity:
                    var equityTransactionCosts = marketValue*0.005m;
                    var equityViewModel = new EquityViewModel
                    {
                        MarketValue = marketValue,
                        TransactionCosts = equityTransactionCosts,
                        Name = $"{stock.Type}{stock.Number}",
                        IsHighlighted = marketValue < 0 || equityTransactionCosts > 200000,
                        StockWeight = marketValue/totalMarketValue
                    };
                    FillStock(equityViewModel, stock);
                    return equityViewModel;

                default:
                    throw new NotSupportedException();
            }
        }

        private void FillStock(StockViewModel stockViewModel, Stock stock)
        {
            stockViewModel.Quantity = stock.Quantity;
            stockViewModel.Price = stock.Price;
            stockViewModel.Type = stock.Type; 
        }
    }
}
