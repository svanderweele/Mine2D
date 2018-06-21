using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Commands
{
    [Command]
    public class CommandRequestAddEntityToGridComponent : IComponent
    {
        
        //TODO : Add layer to request since Entity is not yet part of grid
//        public int layer;

        public int entityId;
        public int gridId;
    }
}