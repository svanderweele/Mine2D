using Entitas;

namespace svanderweele.Core.Pieces.Grid.Core.Components
{
    [Grid]
    public class GridTilesComponent : IComponent
    {
        public TileEntities[,] tiles;
    }
}