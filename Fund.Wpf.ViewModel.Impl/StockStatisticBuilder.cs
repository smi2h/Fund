
using Fund.Domain.Statistic.Models;

namespace Fund.Wpf.ViewModels.Impl
{
    public class StockStatisticBuilder : IStockStatisticBuilder
    {
        public StockStatisticViewModel Build(StockStatistic statistic)
        {
            return new StockStatisticViewModel
            {
                AllTotalMarketValue = statistic.AllTotalMarketValue,
                AllTotalNumber = statistic.AllTotalNumber,
                AllTotalStockWeight = statistic.AllTotalStockWeight,
                BondTotalMarketValue = statistic.BondTotalMarketValue,
                BondTotalNumber = statistic.BondTotalNumber,
                BondTotalStockWeight = statistic.BondTotalStockWeight,
                EquityTotalMarketValue = statistic.EquityTotalMarketValue,
                EquityTotalNumber = statistic.EquityTotalNumber,
                EquityTotalStockWeight = statistic.EquityTotalStockWeight
            };
        }
    }
}
