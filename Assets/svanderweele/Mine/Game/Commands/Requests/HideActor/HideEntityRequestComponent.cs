using Entitas;

namespace svanderweele.Mine.Game.Actions.HideActor
{
    [Command]
    public class HideEntityRequestComponent : IComponent
    {
        public int entityId;
        public bool visible;
    }
}