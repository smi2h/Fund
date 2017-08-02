using Fund.Domain.Statistic.Models;

namespace Fund.Wpf.ViewModels
{
    public interface IStockStatisticBuilder
    {
        StockStatisticViewModel Build(StockStatistic statistic);
    }
}