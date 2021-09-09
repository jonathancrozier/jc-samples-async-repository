namespace JC.Samples.AsyncRepository.Entities
{
    /// <summary>
    /// Represents a 'Todo' item.
    /// </summary>
    public class Todo : IHasId
    {
        #region Properties

        /// <summary>
        /// The unique ID of the Todo item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The ID of the User the Todo item is assigned to.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The Title/Description of the Todo item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Whether or not the Todo item has been completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// The related User record.
        /// </summary>
        public User User { get; set; }

        #endregion
    }
}