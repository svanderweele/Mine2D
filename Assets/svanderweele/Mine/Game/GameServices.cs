using svanderweele.Core.Pieces.Grid.Core.Service;

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