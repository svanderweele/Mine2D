using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Systems
{
    public class GenerateGridSystem : ReactiveSystem<GridEntity>
    {
        private readonly Contexts _context;

        public GenerateGridSystem(Contexts context) : base(context.grid)
        {
            _context = context;
        }

        protected override ICollector<GridEntity> GetTrigger(IContext<GridEntity> context)
        {
            return context.CreateCollector(GridMatcher.AllOf(GridMatcher.Grid, GridMatcher.GridSize).NoneOf(GridMatcher.GridInitialized));
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
                        
                    }


                }
                else
                {
                    //TODO : Load grid + grid tiles

                }


            }
            
            
            
            
            
        }
    }
}