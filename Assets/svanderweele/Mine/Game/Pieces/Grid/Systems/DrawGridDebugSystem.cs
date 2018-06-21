using System.Collections.Generic;
using Entitas;
using svanderweele.Mine.Game.Utils;
using UnityEngine;

namespace svanderweele.Mine.Game.Pieces.Grid.Systems
{
    public class DrawGridDebugSystem : ReactiveSystem<GridEntity>
    {
        private readonly Contexts _contexts;

        public DrawGridDebugSystem(Contexts contexts) : base(contexts.grid)
        {
            _contexts = contexts;
        }

        protected override ICollector<GridEntity> GetTrigger(IContext<GridEntity> context)
        {
            return context.CreateCollector(GridMatcher.AllOf(GridMatcher.Grid, GridMatcher.GridDebug,
                GridMatcher.GridChanged));
        }

        protected override bool Filter(GridEntity entity)
        {
            return entity.isDestroyed == false && entity.isGrid && entity.isGridDebug && entity.isGridChanged;
        }

        protected override void Execute(List<GridEntity> entities)
        {
            foreach (var gridEntity in entities)
            {
                var gridColumns = gridEntity.gridSize.columns;
                var gridRows = gridEntity.gridSize.rows;

                var tileWidth = gridEntity.gridTileSize.tileWidth;
                var tileHeight = gridEntity.gridTileSize.tileHeight;

                var tiles = gridEntity.gridTiles.tiles;


                var debugTiles = _contexts.game.GetEntitiesWithGridTileType(
                    GlobalVariables.ObjectType.JoinTypes(new string[]
                        {ObjectType.OBJECT_CATEGORY_DEBUG, ObjectType.OBJECT_CATEGORY_TILE}));
                Debug.Log("Debug tiles " + debugTiles.Count);

                for (var x = 0; x < gridColumns; x++)
                {
                    for (var y = 0; y < gridRows; y++)
                    {
                        var tileDebug = _contexts.game.CreateEntity();
                        _contexts.meta.viewService.instance.LoadAsset(_contexts, tileDebug, "Grid_Tile_Debug");
                        tileDebug.AddPosition(x * tileWidth, y * tileHeight);
                        tileDebug.AddGridTileType(GlobalVariables.ObjectType.JoinTypes(new string[]
                            {ObjectType.OBJECT_CATEGORY_DEBUG, ObjectType.OBJECT_CATEGORY_TILE}));
                    }
                }
            }
        }
    }
}