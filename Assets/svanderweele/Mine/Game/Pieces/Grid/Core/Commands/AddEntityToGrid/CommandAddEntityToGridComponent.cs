using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Commands
{
    [Command]
    public class CommandAddEntityToGridComponent : IComponent
    {
        public int entityId;
        public int gridId;
        public int layer;
    }
}