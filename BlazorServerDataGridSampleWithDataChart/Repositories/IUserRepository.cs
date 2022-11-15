using BlazorServerDataGridSampleWithDataChart.Data.Models;

namespace BlazorServerDataGridSampleWithDataChart.Repositories
{
    /// <summary>
    /// マスターメンテ用Repositoryインターフェイス
    /// </summary>
    /// <typeparam name="TEntity">モデルを指定する</typeparam>
    public interface IUserRepository : IMasterRepository<User>
    {


    }
}
