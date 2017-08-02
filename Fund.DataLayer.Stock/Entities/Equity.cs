namespace Fund.DataLayer.Stock.Entities
{
    public class Equity : Stock
    {
        public override StockType Type => StockType.Equity;
    }
}
