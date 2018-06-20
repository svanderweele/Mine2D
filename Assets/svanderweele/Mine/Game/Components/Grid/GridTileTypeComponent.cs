using Entitas;

namespace svanderweele.Mine.Game.Components.Grid
{
    [Grid]
    public class GridTileTypeComponent : IComponent
    {
        public TileType[] tileTypes;
    }
}