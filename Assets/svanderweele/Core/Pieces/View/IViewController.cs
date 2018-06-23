using Entitas;

namespace svanderweele.Core.Pieces.View
{
    public interface IViewController
    {
        void Link(Contexts contexts, IEntity entity);
        void Unlink();
        int GetEntityId();
    }
}