using Entitas;
using svanderweele.Mine.Game.Factories.Tile.Data;
using svanderweele.Mine.Game.Utils;

namespace svanderweele.Mine.Game.Factories.Tile
{
    public class TileFactory : ITileFactory
    {
        private readonly Contexts _contexts;

        public TileFactory(Contexts contexts)
        {
            _contexts = contexts;
        }

        public GameEntity CreateTile(TileCreationData data)
        {
            var e = _contexts.game.CreateEntity();
            _contexts.meta.viewService.instance.LoadAsset(_contexts, e,
                GlobalVariables.ResourcesAssetsPath + "prefabs/tile");
            e.isTile = true;
            if (data.Type == TileType.Dirt)
                e.AddSprite("assets/sprites/tiles/dirt/tile-dirt-01");
            if (data.Type == TileType.Stone)
                e.AddSprite("assets/sprites/tiles/dirt/tile-stone-01");
            e.AddTileLayer(0);
            return e;
        }
    }


    public enum TileType
    {
        Dirt = 0,
        Stone = 1,
    }
}