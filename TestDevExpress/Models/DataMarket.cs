using System;
using Newtonsoft.Json;
using TestDevExpress.Interfaces;

namespace TestDevExpress.Models
{
    public class DataMarket : IFinanceData
    {
        [JsonProperty("open")]
        public decimal? OpeningPrice { get; set; }
        [JsonProperty("high")]
        public decimal? HighPrice { get; set; }
        [JsonProperty("low")]
        public decimal? LowPrice { get; set; }
        [JsonProperty("close")]
        public decimal? ClosingPrice { get; set; }
        [JsonProperty("volume")]
        public decimal? Volume { get; set; }
        [JsonProperty("adj_high")]
        public decimal? AdjustedHigh { get; set; }
        [JsonProperty("adj_low")]
        public decimal? AdjustedLow { get; set; }
        [JsonProperty("adj_close")]
        public decimal? AdjustedClose { get; set; }
        [JsonProperty("adj_open")]
        public decimal? AdjustedOpen { get; set; }
        [JsonProperty("adj_volume")]
        public decimal? AdjustedVolume { get; set; }
        [JsonProperty("split_factor")]
        public decimal? SplitFactor { get; set; }
        [JsonProperty("symbol")]
        public string SymbolTicker { get; set; }
        [JsonProperty("exchange")]
        public string Mic { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}
