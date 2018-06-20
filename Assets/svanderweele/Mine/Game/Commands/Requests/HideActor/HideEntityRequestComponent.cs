using Entitas;

namespace svanderweele.Mine.Game.Commands.Requests.HideActor
{
    [Command]
    public class HideEntityRequestComponent : IComponent
    {
        public int entityId;
        public bool visible;
    }
}