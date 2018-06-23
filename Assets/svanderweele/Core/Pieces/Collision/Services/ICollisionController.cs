using Entitas;

namespace svanderweele.Core.Pieces.Collision.Services
{
    public interface ICollisionController
    {
        void Initialize(Contexts contexts, IEntity entity);
    }
}