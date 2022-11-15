using BlazorServerDataGridSampleWithDataChart.Data.Models;
using static Dapper.SqlMapper;

namespace BlazorServerDataGridSampleWithDataChart.Repositories
{
    public interface ISalesDetailRepository : IDetailRepository<SalesDetail>
    {
        void UpdateAll(IList<SalesDetail> entities);
    }
}
