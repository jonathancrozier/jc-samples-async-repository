namespace JC.Samples.AsyncRepository.Entities
{
    /// <summary>
    /// Represents a User.
    /// </summary>
    public class User : IHasId
    {
        #region Properties

        /// <summary>
        /// The unique ID of the User.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Username of the User.
        /// </summary>
        public string Username { get; set; }

        #endregion
    }
}