using System.ComponentModel;
using System.Runtime.CompilerServices;
using Fund.Wpf.ViewModels.Properties;

namespace Fund.Wpf.ViewModels
{
    public class StockStatisticViewModel : INotifyPropertyChanged
    {
        private long _equityTotalNumber;
        private decimal _equityTotalStockWeight;
        private decimal _equityTotalMarketValue;
        private long _bondTotalNumber;
        private decimal _bondTotalStockWeight;
        private decimal _bondTotalMarketValue;
        private long _allTotalNumber;
        private decimal _allTotalStockWeight;
        private decimal _allTotalMarketValue;

        public long EquityTotalNumber
        {
            get { return _equityTotalNumber; }
            set
            {
                _equityTotalNumber = value;
                OnPropertyChanged();
            }
        }
        public decimal EquityTotalStockWeight
        {
            get { return _equityTotalStockWeight; }
            set
            {
                _equityTotalStockWeight = value;
                OnPropertyChanged();
            }
        }
        public decimal EquityTotalMarketValue
        {
            get { return _equityTotalMarketValue; }
            set
            {
                _equityTotalMarketValue = value;
                OnPropertyChanged();
            }
        }
        public long BondTotalNumber
        {
            get { return _bondTotalNumber; }
            set
            {
                _bondTotalNumber = value;
                OnPropertyChanged();
            }
        }
        public decimal BondTotalStockWeight
        {
            get { return _bondTotalStockWeight; }
            set
            {
                _bondTotalStockWeight = value;
                OnPropertyChanged();
            }
        }
        public decimal BondTotalMarketValue
        {
            get { return _bondTotalMarketValue; }
            set
            {
                _bondTotalMarketValue = value;
                OnPropertyChanged();
            }
        }
        public long AllTotalNumber
        {
            get { return _allTotalNumber; }
            set
            {
                _allTotalNumber = value;
                OnPropertyChanged();
            }
        }
        public decimal AllTotalStockWeight
        {
            get { return _allTotalStockWeight; }
            set
            {
                _allTotalStockWeight = value;
                OnPropertyChanged();
            }
        }
        public decimal AllTotalMarketValue
        {
            get { return _allTotalMarketValue; }
            set
            {
                _allTotalMarketValue = value;
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
