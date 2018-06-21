using Entitas;
using svanderweele.Mine.Game.Utils.Math;

namespace svanderweele.Mine.Core.Services.View
{
    public interface IViewController
    {
        Vector2 GetPosition();
        void Link(Contexts contexts, IEntity entity);
        int GetEntityId();
    }
}