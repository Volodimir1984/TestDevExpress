using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestDevExpress.Interfaces;

namespace TestDevExpress.Models
{
    public class MarketStack : IGetFinancesInfo
    {
        private const string Request =
            "http://api.marketstack.com/v1/eod?access_key=11e08378f0ee6e373d3b7b3174ad7025&symbols=AAPL&date_from=2020-07-29&date_to=2021-08-08";

        
        [JsonProperty("data")] public IEnumerable<DataMarket> MarketInfo { get; set; }

        public async Task<IEnumerable<IFinanceData>> GetData()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(Request);

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<MarketStack>(content)?.MarketInfo;

        }
    }
}
