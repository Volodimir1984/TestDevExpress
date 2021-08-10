using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Linq;
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

        [Command]
        public void ExportToCsv(TableView tableView)
        {
            tableView.PrintSelectedRowsOnly = true;

            try
            {
                var filePath = GetFilePath("(*.csv)|*.csv");
                tableView.PrintSelectedRowsOnly = true;
                tableView.ExportToCsv(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        [Command]
        public void ExportToTxt(TableView tableView)
        {
            try
            {
                var filePath = GetFilePath("(*.txt)|*.txt");
                tableView.PrintSelectedRowsOnly = true;
                tableView.ExportToText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string GetFilePath(string filter)
        {
            var dialog = new SaveFileDialog
            {
                Filter = filter
            };

            return dialog.ShowDialog() == false ? null : dialog.FileNames.First();
        }
    }
}