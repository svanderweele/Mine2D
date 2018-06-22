using Entitas;

namespace svanderweele.Mine.Core.Services.Collision
{
    public interface ICollisionController
    {
        void Initialize(Contexts contexts, IEntity entity);
    }
}