using svanderweele.Mine.Game.Utils;

namespace svanderweele.Mine.Game.Pieces.Grid.Service
{
    public class GridService : IGridService
    {
        private readonly Contexts _contexts;

        public GridService(Contexts contexts)
        {
            _contexts = contexts;
        }

        public bool CanAddEntityToGrid()
        {
            throw new System.NotImplementedException();
        }

        public bool AddEntityToGrid(int entity, int grid)
        {
            throw new System.NotImplementedException();
        }
    }
}