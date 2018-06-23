using Entitas;

namespace svanderweele.Core.Pieces.Events.Interfaces
{
    public interface IEventListener
    {
        void RegisterEvents(Contexts contexts, IEntity entity);
    }
}