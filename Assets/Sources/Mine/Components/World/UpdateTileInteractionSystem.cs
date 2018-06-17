
using Entitas;
using System.Collections.Generic;

public class UpdateTileInteractionSystem : ReactiveSystem<GameEntity>
{

    private Contexts _contexts;

    public UpdateTileInteractionSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> contexts)
    {
        return contexts.CreateCollector(GameMatcher.Grid);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasGrid && entity.grid.ShouldRefresh;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity e in entities)
        {

            var gridEID = e.eID.value;
            int gridColumns = e.grid.Columns;
            int gridRows = e.grid.Rows;
            var gridEntities = e.gridTiles.Tiles;

            //Iterate over each tile and update
            for (var x = 0; x < gridColumns; x++)
            {
                for (var y = 0; y < gridRows; y++)
                {
                    var tileEID = gridEntities[x,y];
                    var gridTile = _contexts.game.GetEntityWithEID(tileEID);


                }
            }
        }
    }


}