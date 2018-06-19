using Entitas;

namespace svanderweele.Mine.Game.Actions
{
    [Action]
    public class HideEntityActionComponent : IComponent
    {
        public int entityId;
        public bool visible;
    }
}