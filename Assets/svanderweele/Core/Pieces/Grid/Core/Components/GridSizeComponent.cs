using Entitas;

namespace svanderweele.Core.Pieces.Grid.Core.Components
{
    [Grid]
    public class GridSizeComponent : IComponent
    {
        public int columns;
        public int rows;
    }
}