using System;
using DevExpress.Mvvm;
using Newtonsoft.Json;
using TestDevExpress.Interfaces;

namespace TestDevExpress.Models
{
    public class DataMarket : ViewModelBase, IFinanceData
    {
        [JsonProperty("open")]
        public decimal? OpeningPrice
        {
            get => GetValue<decimal>(nameof(OpeningPrice));
            set => SetValue(value, nameof(OpeningPrice));
        }
        [JsonProperty("high")]
        public decimal? HighPrice
        {
            get => GetValue<decimal>(nameof(HighPrice));
            set => SetValue(value, nameof(HighPrice));
        }
        [JsonProperty("low")]
        public decimal? LowPrice
        {
            get => GetValue<decimal>(nameof(LowPrice));
            set => SetValue(value, nameof(LowPrice));
        }
        [JsonProperty("close")]
        public decimal? ClosingPrice
        {
            get => GetValue<decimal>(nameof(ClosingPrice));
            set => SetValue(value, nameof(ClosingPrice));
        }
        [JsonProperty("volume")]
        public decimal? Volume
        {
            get => GetValue<decimal>(nameof(Volume));
            set => SetValue(value, nameof(Volume));
        }
        [JsonProperty("adj_high")]
        public decimal? AdjustedHigh
        { 
            get => GetValue<decimal>(nameof(AdjustedHigh));
            set=> SetValue(value, nameof(AdjustedHigh));
        }
    [JsonProperty("adj_low")]
        public decimal? AdjustedLow
        {
            get => GetValue<decimal>(nameof(AdjustedLow));
            set => SetValue(value, nameof(AdjustedLow));
        }

        [JsonProperty("adj_close")]
        public decimal? AdjustedClose
        {
            get => GetValue<decimal>(nameof(AdjustedClose));
            set => SetValue(value, nameof(AdjustedClose));
        }
        [JsonProperty("adj_open")]
        public decimal? AdjustedOpen
        {
            get => GetValue<decimal>(nameof(AdjustedOpen));
            set => SetValue(value, nameof(AdjustedOpen));
        }
        [JsonProperty("adj_volume")]
        public decimal? AdjustedVolume
        {
            get => GetValue<decimal>(nameof(AdjustedVolume));
            set => SetValue(value, nameof(AdjustedVolume));
        }
        [JsonProperty("split_factor")]
        public decimal? SplitFactor
        {
            get => GetValue<decimal>(nameof(SplitFactor));
            set => SetValue(value, nameof(SplitFactor));
        }
        [JsonProperty("symbol")]
        public string SymbolTicker
        {
            get => GetValue<string>(nameof(SymbolTicker));
            set => SetValue(value, nameof(SymbolTicker));
        }
        [JsonProperty("exchange")]
        public string Mic
        {
            get => GetValue<string>(nameof(Mic));
            set => SetValue(value, nameof(Mic));
        }

        [JsonProperty("date")]
        public DateTime Date
        {
            get => GetValue<DateTime>(nameof(Date));
            set => SetValue(value, nameof(Date));
        }
    }
}
