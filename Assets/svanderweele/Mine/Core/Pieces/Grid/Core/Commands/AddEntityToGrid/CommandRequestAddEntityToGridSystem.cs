using System.Collections.Generic;
using Entitas;
using svanderweele.Mine.Core.Pieces.Commands;
using svanderweele.Mine.Game.Utils;
using UnityEngine;

namespace svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid
{
    public class CommandRequestAddEntityToGridSystem : ReactiveSystem<CommandEntity>
    {
        private readonly Contexts _contexts;

        public CommandRequestAddEntityToGridSystem(Contexts contexts) : base(contexts.command)
        {
            _contexts = contexts;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher
                .AllOf(CommandMatcher.Command, CommandMatcher.CommandRequest,
                    CommandMatcher.CommandRequestAddEntityToGrid)
                .NoneOf(CommandMatcher.CommandDelay, CommandMatcher.CommandConsumed));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.isCommand && entity.isDestroyed == false && entity.isCommandConsumed == false &&
                   entity.isCommandRequest;
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var commandEntity in entities)
            {
                var entityId = commandEntity.commandRequestAddEntityToGrid.entityId;
                var entity = _contexts.game.GetEntityWithId(entityId);

                //Is entity of right type
                var gridId = commandEntity.commandRequestAddEntityToGrid.gridId;
                var grid = _contexts.grid.GetEntityWithId(gridId);

                var entityType = entity.gridTileType.type;
                var gridType = grid.gridTileType.type;

                if (GlobalVariables.ObjectType.Matches(entityType, gridType) == false)
                {
                    Debug.Log("Can't place tile on grid - Wrong Category " + entityType);
                    commandEntity.isCommandConsumed = true;
                    return;
                }

                //Check if tile is vacant on layer
                int layer = commandEntity.commandRequestAddEntityToGrid.layer;
                var entitiesOnSameLayer = _contexts.game.GetEntitiesWithGridLayer(layer);
                var entitiesOnSameLayerIds = new List<int>();

                foreach (var gameEntity in entitiesOnSameLayer)
                {
                    entitiesOnSameLayerIds.Add(gameEntity.id.value);
                }


                bool collision = _contexts.meta.collisionService.service.AreColliding(entityId, entitiesOnSameLayerIds);

                if (collision == false)
                {
                    var cmd = _contexts.command.CreateCommand(0);
                    cmd.AddCommandAddEntityToGrid(entityId, gridId, layer);
                    commandEntity.isCommandConsumed = true;
                }
                else
                {
                    Debug.Log("Can't place Entity");
                    commandEntity.isCommandConsumed = true;
                }
            }
        }
    }
}