using System.ComponentModel;
using System.Runtime.CompilerServices;
using Fund.DataLayer.Stock.Entities;
using Fund.Wpf.ViewModels.Properties;

namespace Fund.Wpf.ViewModels
{
    public abstract class StockViewModel : INotifyPropertyChanged
    {
        public StockType Type { get; set; }
        public decimal Price { get; set; }
        public long Quantity { get; set; }
        public decimal MarketValue  { get; set; }
        public virtual decimal TransactionCosts { get; set; }
        public decimal StockWeight { get; set; }
        public bool IsHighlighted { get; set; }
        public string Name { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
     
}
