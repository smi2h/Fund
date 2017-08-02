using System.Collections.Generic;
using Fund.DataLayer.Stock.Entities;

namespace Fund.DataLayer.Stock
{
    public class StockRepository : IStockRepository
    {
        private static readonly List<Entities.Stock> Stocks = new List<Entities.Stock>()
        {
            new Equity { Number = 1, Price = 10, Quantity = 10 },
            new Equity { Number = 2, Price = 20, Quantity = 20 },
            new Bond { Number = 1, Price = 30, Quantity = 30 },
            new Bond { Number = 2, Price = 40, Quantity = 40 },
            new Bond { Number = 3, Price = 50, Quantity = 50 },
            new Bond { Number = 4, Price = 60, Quantity = 60 },
            new Equity { Number = 3, Price = 70, Quantity = 70 },
            new Equity { Number = 4, Price = 80, Quantity = 80 },
            new Bond { Number = 5, Price = 90, Quantity = 90 },
            new Bond { Number = 6, Price = 100, Quantity = 100 },
            new Bond { Number =7, Price = 110, Quantity = 110 },
            new Bond { Number = 8, Price = 120, Quantity = 120 },

            new Bond { Number = 9, Price = -200, Quantity = 100 },
            new Equity { Number =5, Price = -200, Quantity = 110 },

            new Bond { Number = 10, Price = 100000, Quantity = 100 },
            new Equity { Number =6, Price = 200000, Quantity = 110 },
        };

        public Entities.Stock[] GetStocks()
        {
            return Stocks.ToArray();
        }

        public void AddStocks(Entities.Stock stock)
        {
            Stocks.Add(stock);
        }
    }
}