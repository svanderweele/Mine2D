using Entitas;

namespace svanderweele.Mine.Game.Components.Grid
{
    [Grid]
    public class GridSizeComponent : IComponent
    {
        public int columns;
        public int rows;
    }
}