using svanderweele.Mine.Game.Utils;

namespace svanderweele.Mine.Game.Pieces.Grid.Service
{
    public interface IGridService
    {
        bool CanAddEntityToGrid();
        bool AddEntityToGrid(int entity, int grid);
    }
}