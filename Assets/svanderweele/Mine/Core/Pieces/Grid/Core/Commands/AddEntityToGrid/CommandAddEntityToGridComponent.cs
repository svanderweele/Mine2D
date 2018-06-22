using Entitas;

namespace svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid
{
    [Command]
    public class CommandAddEntityToGridComponent : IComponent
    {
        public int entityId;
        public int gridId;
        public int layer;
    }
}