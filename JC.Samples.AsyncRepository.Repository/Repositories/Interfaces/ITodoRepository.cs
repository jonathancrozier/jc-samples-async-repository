using JC.Samples.AsyncRepository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JC.Samples.AsyncRepository.Repository
{
    /// <summary>
    /// Todo Repository Interface.
    /// </summary>
    public interface ITodoRepository : IBaseRepository<Todo>
    {
        #region Methods

        Task<IEnumerable<Todo>> GetTopXIncompleteTodosAsync(int x);

        #endregion
    }
}