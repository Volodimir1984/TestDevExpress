using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using TestDevExpress.Interfaces;

namespace TestDevExpress.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IGetFinancesInfo _market;

        public MainViewModel(IGetFinancesInfo financesInfo)
        {
            _market = financesInfo;
        }

        public ObservableCollection<IFinanceData> Market
        {
            get => GetValue<ObservableCollection<IFinanceData>>(nameof(Market));
            set => SetValue(value, nameof(Market));
        }

        [Command]
        public async Task GetData()
        {
            try
            {
                var result = await _market.GetData().ConfigureAwait(false);
                Market = new ObservableCollection<IFinanceData>(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}