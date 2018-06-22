using Entitas;

namespace svanderweele.Mine.Core.Pieces.Grid.Core.Components
{
    [Grid]
    public class GridTilesComponent : IComponent
    {
        public TileEntities[,] tiles;
    }
}