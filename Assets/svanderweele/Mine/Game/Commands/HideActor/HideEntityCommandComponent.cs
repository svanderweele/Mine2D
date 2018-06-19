using Entitas;

namespace svanderweele.Mine.Game.Commands
{
    [Command]
    public class HideEntityCommandComponent : IComponent
    {
        public int entityId;
        public bool visible;
    }
}