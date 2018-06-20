using Entitas;
using svanderweele.Mine.Game.Utils;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Grid]
    public class GridTileTypeComponent : IComponent
    {
        public TileType[] tileTypes;
    }
}