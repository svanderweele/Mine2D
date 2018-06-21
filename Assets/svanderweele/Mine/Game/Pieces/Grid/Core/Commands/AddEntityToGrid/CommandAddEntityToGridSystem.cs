using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.Game.Pieces.Grid.Commands.AddEntityToGrid
{
    public class CommandAddEntityToGridSystem : ReactiveSystem<CommandEntity>
    {
        private readonly Contexts _contexts;

        public CommandAddEntityToGridSystem(Contexts contexts) : base(contexts.command)
        {
            _contexts = contexts;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher
                .AllOf(CommandMatcher.Command,
                    CommandMatcher.CommandAddEntityToGrid)
                .NoneOf(CommandMatcher.CommandDelay, CommandMatcher.CommandConsumed));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.isCommand && entity.isDestroyed == false && entity.isCommandConsumed == false;
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var commandEntity in entities)
            {
                var layer = commandEntity.commandAddEntityToGrid.layer;
                var entity = _contexts.game.GetEntityWithId(commandEntity.commandAddEntityToGrid.entityId);
                entity.AddGridLayer(layer);
                commandEntity.isCommandConsumed = true;
            }
        }
    }
}