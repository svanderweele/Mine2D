using Entitas;
using svanderweele.Core.Factories.Tile.Data;

namespace svanderweele.Mine.Game.Factories.Tile
{
    public interface ITileFactory
    {
        T CreateTile<T>(ITileCreationData data) where T : IEntity;
    }
    
}