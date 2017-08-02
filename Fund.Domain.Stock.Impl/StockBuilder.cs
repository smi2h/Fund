using System;
using Fund.DataLayer.Stock.Entities;

namespace Fund.Services
{
    public class StockBuilder : IStockBuilder
    {
        public Stock Build(StockType type, decimal price, int quantity, int number)
        {
            switch (type)
            {
                case StockType.Bond:
                    return new Bond
                    {
                        Quantity = quantity,
                        Price = price,
                        Number = number
                    };
                case StockType.Equity:
                    return new Equity
                    {
                        Quantity = quantity,
                        Price = price,
                        Number = number
                    };
                default:
                    throw new ArgumentOutOfRangeException("stockType");
            }
        }
    }
}