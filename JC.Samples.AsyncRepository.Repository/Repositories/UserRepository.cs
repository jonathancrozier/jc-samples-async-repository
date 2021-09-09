using JC.Samples.AsyncRepository.Entities;

namespace JC.Samples.AsyncRepository.Repository
{
    /// <summary>
    /// User Repository.
    /// </summary>
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbContext">The Database Context</param>
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        #endregion
    }
}