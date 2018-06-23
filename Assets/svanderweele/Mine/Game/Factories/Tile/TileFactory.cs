using Entitas;
using svanderweele.Core.Factories.Tile.Data;

namespace svanderweele.Mine.Game.Factories.Tile
{
    public class TileFactory : ITileFactory
    {
        private readonly Contexts _contexts;

        public TileFactory(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public T CreateTile<T>(ITileCreationData data) where T : IEntity
        {
            return default(T);
        }
    }


    public enum TileType
    {
        Dirt = 0,
        Stone = 1,
    }
}