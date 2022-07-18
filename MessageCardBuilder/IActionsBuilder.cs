namespace MessageCard.Builder
{
    /// <summary>
    ///
    /// </summary>
    public interface IActionsBuilder<T> where T : IAction
    {
        /// <summary>
        /// Adds a block element to the array.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        IActionsBuilder<T> AddAction(T action);
    }
}