using Entitas;

namespace svanderweele.Mine.Core.Services.Events
{
    public interface IEventListener
    {
        void RegisterEvents(Contexts contexts, IEntity entity);
    }
}