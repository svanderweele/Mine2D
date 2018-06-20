using Entitas;

namespace svanderweele.Mine.Game.Components.Grid
{
    [Grid]
    public class GridTilesComponent : IComponent
    {
        public int[,] tiles;
    }
}