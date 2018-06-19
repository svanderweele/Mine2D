using Entitas;

namespace svanderweele.Mine.Core.Services.View
{
    public interface IViewController
    {
        void Link(Contexts contexts, IEntity entity);    
    }
}