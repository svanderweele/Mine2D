using Entitas;

namespace svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid
{
    [Action]
    public class ActionRequestAddEntityToGridComponent : IComponent
    {
        
        public int entityId;
        public int gridId;
        public int layer;
    }
}