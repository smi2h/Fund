namespace Fund.DataLayer.Stock.Entities
{
    public class Bond : Stock
    {
        public override StockType Type => StockType.Bond;
    }
}
