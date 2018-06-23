using System.Collections.Generic;
using Entitas;
using svanderweele.Core.Pieces.Map.Data;
using svanderweele.Mine.Game.Factories.Tile;
using svanderweele.Mine.Game.Factories.Tile.Data;

namespace svanderweele.Mine.MapEditor.Pieces.MapEditor.Actions.CreateMap
{
    public class ActionCreateMapSystem : ReactiveSystem<ActionEntity>
    {
        private readonly Contexts _contexts;

        public ActionCreateMapSystem(Contexts contexts) : base(contexts.action)
        {
            _contexts = contexts;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher.AllOf(ActionMatcher.ActionCreateMap)
                .NoneOf(ActionMatcher.Delay, ActionMatcher.Consumed));
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.hasActionCreateMap && entity.hasDelay == false && entity.isConsumed == false;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var entity in entities)
            {
                var creationData = entity.actionCreateMap;
                var x = creationData.size.x;
                var y = creationData.size.y;

                var backgroundTileData = new TileCreationData()
                {
                    Type = creationData.BackgroundTile
                };


                //TODO : Convert 0,1 to LayerEnum?
                //TODO : Add tile config files for default data setting (SellValue, DefaultHealth, SpawnChance)
                //TODO : Add another layer for ores to replace already created tiles (Generate int array (eg: 8x8) and
                //randomly tick 1, 0, 1 = ore, 0 = no ore for grouping ore
                
                //TODO : Background is only created for certain rooms/areas, the rest will be a looping texture
//                var backgroundTiles = GenerateTiles(x, y, backgroundTileData, 0);
                var foregroundTiles = GenerateTiles(x, y, backgroundTileData, 1);

                var tiles = new Dictionary<int, int[,]> {{1, foregroundTiles}};

                var map = CreateMap();
                map.ReplaceMapTiles(tiles);

                entity.isConsumed = true;
            }
        }

        private int[,] GenerateTiles(int columns, int rows, TileCreationData creationData, int layer)
        {
            int[,] tiles = new int[columns, rows];
            for (int xIndex = 0; xIndex < columns; xIndex++)
            {
                for (int yIndex = 0; yIndex < rows; yIndex++)
                {
                    var tile = _contexts.factory.tileFactory.factory.CreateTile(creationData);
                    tile.ReplaceTileLayer(layer);
                    //TODO : Create snap to grid system
                    tile.AddSnapToGrid(xIndex, yIndex);
                    tile.AddPosition(xIndex * 1, yIndex * 1);
                    tiles[xIndex, yIndex] = tile.id.value;
                }
            }

            return tiles;
        }

        public GameEntity CreateMap(MapData data = null)
        {
            if (data == null)
            {
                data = MapData.Default;
            }

            var e = _contexts.game.CreateEntity();
            e.isMap = true;
            e.AddMapData(data);
            e.AddMapTiles(new Dictionary<int, int[,]>());
            e.AddMapObjects(new List<int>());
            return e;
        }
    }
}