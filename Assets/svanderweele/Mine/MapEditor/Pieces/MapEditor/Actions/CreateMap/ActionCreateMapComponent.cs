using Entitas;
using svanderweele.Mine.Game.Factories.Tile;
using svanderweele.Mine.Game.Utils.Math;

namespace svanderweele.Mine.MapEditor.Pieces.MapEditor.Actions.CreateMap
{
    [Action]
    public class ActionCreateMapComponent : IComponent
    {
        public Vector2Int size;
        public TileType BackgroundTile;
        public TileType ForegroundTile;
    }
}