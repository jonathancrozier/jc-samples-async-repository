using JC.Samples.AsyncRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace JC.Samples.AsyncRepository.Repository
{
    /// <summary>
    /// The context class which represents the connection to the app database.
    /// </summary>
    public class AppDbContext : DbContext
    {
        #region Properties

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">The options to use</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Allows the database model to be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        #endregion
    }
}