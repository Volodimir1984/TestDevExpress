using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestDevExpress.Interfaces
{
    public interface IGetFinancesInfo
    {
        public Task<IEnumerable<IFinanceData>> GetData();
    }
}
