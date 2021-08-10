using DevExpress.Xpf.Bars;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;

namespace TestDevExpress.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void ExportToCsv(object sender, ItemClickEventArgs e)
        {

            try
            {
                var filePath = GetFilePath("(*.csv)|*.csv");
                Tb.PrintSelectedRowsOnly = true;
                Tb.ExportToCsv(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ExportToTxt(object sender, ItemClickEventArgs e)
        {
            try
            {
                var filePath = GetFilePath("(*.txt)|*.txt");
                Tb.PrintSelectedRowsOnly = true;
                Tb.ExportToText(filePath);
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
