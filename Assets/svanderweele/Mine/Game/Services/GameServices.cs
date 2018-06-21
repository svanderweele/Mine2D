using svanderweele.Mine.Game.Pieces.Grid.Service;

namespace svanderweele.Mine.Game.Services
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