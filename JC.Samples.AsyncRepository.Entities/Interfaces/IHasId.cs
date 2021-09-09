namespace JC.Samples.AsyncRepository.Entities
{
    /// <summary>
    /// Interface for all entities which have an ID primary key.
    /// </summary>
    public interface IHasId
    {
        #region Properties

        int Id { get; }

        #endregion
    }
}