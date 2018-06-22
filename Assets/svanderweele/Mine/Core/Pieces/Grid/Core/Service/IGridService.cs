namespace svanderweele.Mine.Core.Pieces.Grid.Core.Service
{
    public interface IGridService
    {
        bool CanAddEntityToGrid();
        bool AddEntityToGrid(int entity, int grid);
    }
}