using System.Collections.Generic;
using Entitas;
using svanderweele.Mine.Game.Pieces.Grid.Components;
using svanderweele.Mine.Game.Utils;
using UnityEngine;
using UnityEngine.WSA;

namespace svanderweele.Mine.Game.Pieces.Grid.Systems
{
    public class GenerateGridSystem : ReactiveSystem<GridEntity>
    {
        private readonly Contexts _contexts;

        public GenerateGridSystem(Contexts contexts) : base(contexts.grid)
        {
            _contexts = contexts;
        }

        protected override ICollector<GridEntity> GetTrigger(IContext<GridEntity> context)
        {
            return context.CreateCollector(GridMatcher.AllOf(GridMatcher.Grid, GridMatcher.GridSize)
                .NoneOf(GridMatcher.GridInitialized));
        }

        protected override bool Filter(GridEntity entity)
        {
            return entity.isGrid && entity.isGridInitialized == false;
        }

        protected override void Execute(List<GridEntity> entities)
        {
            foreach (var gridEntity in entities)
            {
                if (gridEntity.isNewGrid)
                {
                    //Generate new grid
                    var gridColumns = gridEntity.gridSize.columns;
                    var gridRows = gridEntity.gridSize.rows;

                    var tileWidth = gridEntity.gridTileSize.tileWidth;
                    var tileHeight = gridEntity.gridTileSize.tileHeight;


                    var tiles = gridEntity.gridTiles.tiles;
                    var tileColumns = tiles.GetLength(0);
                    var tileRows = tiles.GetLength(1);


                    if (gridColumns != tileColumns || gridRows != tileRows)
                    {
                        tiles = new TileEntities[gridColumns, gridRows];

                        for (var x = 0; x < gridColumns; x++)
                        {
                            for (var y = 0; y < gridRows; y++)
                            {
                                //TODO : Change this to AddTileCommandRequest to check that grid tile is vacant
                                var tile = _contexts.game.CreateEntity();
                                _contexts.meta.viewService.instance.LoadAsset(_contexts, tile, "Tile");
                                tile.AddSprite(AssetPaths.TILE_DIRT);
                                tile.AddPosition(x * tileWidth, y * tileHeight);
                                tile.AddGridLayer((int) GlobalVariables.Layer.Background);

                                var typeString =
                                    GlobalVariables.ObjectType.GetType(new[] {ObjectType.OBJECT_CATEGORY_TILE});

                                tile.AddGridTileType(typeString);

                                tiles[x, y] = new TileEntities();
                                tiles[x, y].Entities.Add(tile.id.value);
                            }
                        }
                    }

                    gridEntity.isGridInitialized = true;
                }
                else
                {
                    //TODO : Load grid + grid tiles
                }
            }
        }
    }
}