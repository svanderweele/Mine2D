using Entitas;

namespace svanderweele.Mine.Game.Commands.HideActor
{
    [Command]
    public class HideEntityCommandComponent : IComponent
    {
        public int entityId;
        public bool visible;
    }
}