using BlazorServerDataGridSampleWithDataChart.Data;
using BlazorServerDataGridSampleWithDataChart.Data.Models;

namespace BlazorServerDataGridSampleWithDataChart.Repositories
{

    public class UserRepository : MasterRepository<User>, IUserRepository
    {
        public UserRepository(SampleDbContext context, ILogger<UserRepository> logger)
            : base(context, logger)
        {

        }

        public SampleDbContext SampleDbContext
        {
            get { return _context as SampleDbContext; }
        }


    }
}
