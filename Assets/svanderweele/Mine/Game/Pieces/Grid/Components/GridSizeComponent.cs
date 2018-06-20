using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Grid]
    public class GridSizeComponent : IComponent
    {
        public int columns;
        public int rows;
    }
}