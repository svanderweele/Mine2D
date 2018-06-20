using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Grid]
    public class GridTilesComponent : IComponent
    {
        public int[,] tiles;
    }
}