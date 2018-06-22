using Entitas;
using svanderweele.Mine.Game.Utils.Math;

namespace svanderweele.Mine.Core.Services.View
{
    public interface IViewController
    {
        void Link(Contexts contexts, IEntity entity);
        void Unlink();
        int GetEntityId();
    }
}