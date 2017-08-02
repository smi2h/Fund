using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using Fund.DataLayer.Stock.Entities;
using Fund.Domain.Statistic;
using Fund.Domain.Stock;
using Fund.Wpf.ViewModel.Command;
using Fund.Wpf.ViewModels.Properties;

namespace Fund.Wpf.ViewModels
{
    public class FundViewModel : IFundViewModel, INotifyPropertyChanged, IDataErrorInfo
    {
        private readonly IStockService _stockService;
        private readonly IStockFactory _factory;
        private readonly IStockStatisticService _stockStatisticService;
        private readonly IStockStatisticBuilder _statisticBuilder;

        private StockType _selectedStockType;
        private int? _quantity;
        private decimal? _price;
        private ObservableCollection<StockViewModel> _stocks;
        private StockStatisticViewModel _stockStatistic;

        public FundViewModel(IStockService stockService, IStockFactory factory, IStockStatisticService stockStatisticService, IStockStatisticBuilder statisticBuilder)
        {
            _stockService = stockService;
            _factory = factory;
            _stockStatisticService = stockStatisticService;
            _statisticBuilder = statisticBuilder;
            LoadData();
        }

        private void AddStock()
        {
            if (!string.IsNullOrEmpty(this[nameof(Price)]) || !string.IsNullOrEmpty(this[nameof(Quantity)]))
                return;

            _stockService.AddStock(SelectedStockType, Price.Value, Quantity.Value);
            LoadData();
        }

        private void LoadData()
        {
            var stocks = _stockService.GetStocks();
            var statistic = _stockStatisticService.GetStatistic();

            Stocks = new ObservableCollection<StockViewModel>(stocks.Select(p => _factory.Build(p, statistic.AllTotalMarketValue)));
            Statistic = _statisticBuilder.Build(statistic);
        }


        private RelayCommand _addStockCommand;
        public RelayCommand AddStockCommand
        {
            get
            {
                return _addStockCommand ?? (_addStockCommand = new RelayCommand(obj => AddStock()));
            }
        }

        public StockType SelectedStockType
        {
            get { return _selectedStockType; }
            set
            {
                _selectedStockType = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "Quantity is Required")]
        public int? Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "Price is Required")]
        public decimal? Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        public StockStatisticViewModel Statistic
        {
            get { return _stockStatistic; }
            set
            {
                _stockStatistic = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<StockViewModel> Stocks
        {
            get { return _stocks; }
            set
            {
                _stocks = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string this[string columnName]
        {
            get
            {
                var validationResults = new List<ValidationResult>();

                if (Validator.TryValidateProperty(
                    GetType().GetProperty(columnName).GetValue(this)
                    , new ValidationContext(this)
                    {
                        MemberName = columnName
                    }
                    , validationResults))
                    return null;

                return validationResults.First().ErrorMessage;
            }
        }

        public string Error => null;
    }
}
