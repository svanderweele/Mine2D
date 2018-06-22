using svanderweele.Mine.Core.Pieces.Grid.Core.Service;
using svanderweele.Mine.Core.Pieces.GridEditor.Service;

namespace svanderweele.Mine.Game
{
    public class GameServices
    {
        public readonly IGridService Grid;
        public GameServices(IGridService grid)
        {
            this.Grid = grid;
        }
    }
}