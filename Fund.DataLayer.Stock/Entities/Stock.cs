namespace Fund.DataLayer.Stock.Entities
{
    public abstract class Stock
    {
        public int Number { get; set; }
        public abstract StockType Type { get; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
