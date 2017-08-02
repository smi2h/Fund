using System.Windows;
using Fund.Wpf.ViewModels;

namespace Fund.Wpf.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow(IFundViewModel FundViewModel)
        {
            this.DataContext = FundViewModel;
            InitializeComponent();
        }
    }
}
