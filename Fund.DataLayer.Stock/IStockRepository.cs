namespace Fund.DataLayer.Stock
{
    public interface IStockRepository
    {
        Entities.Stock[] GetStocks();
        void AddStocks(Entities.Stock stock);
    }
}
