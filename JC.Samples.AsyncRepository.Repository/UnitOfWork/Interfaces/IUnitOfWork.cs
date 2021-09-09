using System;
using System.Threading.Tasks;

namespace JC.Samples.AsyncRepository.Repository
{
    /// <summary>
    /// Unit of Work Interface.
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        #region Properties

        ITodoRepository TodoRepository { get; }
        IUserRepository UserRepository { get; }

        #endregion

        #region Methods

        Task CompleteAsync();

        #endregion
    }
}