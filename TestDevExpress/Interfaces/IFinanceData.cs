using System;

namespace TestDevExpress.Interfaces
{
    public interface IFinanceData
    {
        public decimal? OpeningPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosingPrice { get; set; }
        public decimal? Volume { get; set; }
        public decimal? AdjustedHigh { get; set; }
        public decimal? AdjustedLow { get; set; }
        public decimal? AdjustedClose { get; set; }
        public decimal? AdjustedOpen { get; set; }
        public decimal? AdjustedVolume { get; set; }
        public decimal? SplitFactor { get; set; }
        public string SymbolTicker { get; set; }
        public string Mic { get; set; }
        public DateTime Date { get; set; }
    }
}
