using System.Collections.Generic;

namespace MessageCard.Builder.Builders
{
    internal class ActionsBuilder<T> : IActionsBuilder<T> where T : IAction
    {
        private readonly List<T> _actions = new List<T>();

        internal IReadOnlyList<T> Build()
        {
            return _actions.AsReadOnly();
        }

        public IActionsBuilder<T> AddAction(T action)
        {
            _actions.Add(action);
            return this;
        }
    }
}