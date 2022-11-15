using BlazorServerDataGridSampleWithDataChart.Data.Models;
using BlazorServerDataGridSampleWithDataChart.Data.ViewModels;
using static Dapper.SqlMapper;

namespace BlazorServerDataGridSampleWithDataChart.Services
{
    interface ISalesDetailService : IDetailService<SalesDetail>
    {
        IList<SalesDetailViewModel> GetDispAll();
    }
}
