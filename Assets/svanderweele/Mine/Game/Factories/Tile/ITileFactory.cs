using Entitas;
using svanderweele.Mine.Game.Factories.Tile.Data;

namespace svanderweele.Mine.Game.Factories.Tile
{
    public interface ITileFactory
    {
        GameEntity CreateTile(TileCreationData data);
    }
    
}