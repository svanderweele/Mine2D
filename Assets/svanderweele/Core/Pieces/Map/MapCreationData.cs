using svanderweele.Mine.Game.Factories.Tile;
using svanderweele.Mine.Game.Utils.Math;

namespace svanderweele.Core.Pieces.Map
{
    public class MapCreationData
    {
        public Vector2 Size { get; set; }
        public TileType ForegroundTile { get; set; }
        public TileType BackgroundTile { get; set; }
    }
}