namespace Fund.Domain.Statistic.Models
{
    public class StockStatistic
    {
        public long EquityTotalNumber { get; set; }
        public decimal EquityTotalStockWeight { get; set; }
        public decimal EquityTotalMarketValue { get; set; }
        public long BondTotalNumber { get; set; }
        public decimal BondTotalStockWeight { get; set; }
        public decimal BondTotalMarketValue { get; set; }
        public long AllTotalNumber { get; set; }
        public decimal AllTotalStockWeight { get; set; }
        public decimal AllTotalMarketValue { get; set; } 
    }
}
