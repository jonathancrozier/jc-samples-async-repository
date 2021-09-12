﻿using System;
using System.Threading.Tasks;

namespace JC.Samples.AsyncRepository.Repository
{
    /// <summary>
    /// Encapsulates all repository transactions.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties

        private TodoRepository _todoRepository;
        public ITodoRepository TodoRepository => _todoRepository ?? (_todoRepository = new TodoRepository(_dbContext));

        private UserRepository _userRepository;
        public IUserRepository UserRepository => _userRepository ?? (_userRepository = new UserRepository(_dbContext));

        #endregion

        #region Readonlys

        private readonly AppDbContext _dbContext;

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbContext">The Database Context</param>
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #region Methods

        /// <summary>
        /// Completes the unit of work, saving all repository changes to the underlying data-store.
        /// </summary>
        /// <returns>The number of state entries written to the underlying data-store</returns>
        public async Task CompleteAsync() => await _dbContext.SaveChangesAsync();

        #endregion

        #region Implements IDisposable

        #region Private Dispose Fields

        private bool _disposed;

        #endregion

        /// <summary>
        /// Cleans up any resources being used.
        /// </summary>
        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);

            // Take this object off the finalization queue to prevent 
            // finalization code for this object from executing a second time.
            GC.SuppressFinalize(this);
        }

        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing) await _dbContext.DisposeAsync(); // Dispose managed resources.

                // Dispose any unmanaged resources here...

                _disposed = true;
            }
        }

        #endregion
    }
}