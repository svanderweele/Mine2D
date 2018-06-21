using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.Game.Pieces.Grid.Commands.AddEntityToGrid
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
                var grid = _contexts.grid.GetEntityWithId(commandEntity.commandRequestAddEntityToGrid.gridId);
                int layer = entity.gridLayer.layer;

                //Check if tile is vacant on layer
                var entitiesOnSameLayer = _contexts.game.GetEntitiesWithGridLayer(layer);
                var entitiesOnSameLayerIds = new List<int>();

                foreach (var gameEntity in entitiesOnSameLayer)
                {
                    entitiesOnSameLayerIds.Add(gameEntity.id.value);
                }


                bool collision = _contexts.meta.collisionService.service.AreColliding(entityId, entitiesOnSameLayerIds);

                if (collision == false)
                {
                    Debug.Log("Can place Entity");
                }
                else
                {
                    Debug.Log("Can't place Entity");                    
                }

                commandEntity.isCommandConsumed = true;
            }
        }
    }
}