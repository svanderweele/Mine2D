using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.Game.Actions
{
    public class RemoveCommandsSystem : ReactiveSystem<CommandEntity>
    {
        private readonly  CommandContext _actionContext;

        public RemoveCommandsSystem(Contexts contexts) : base(contexts.command)
        {
            _actionContext = contexts.command;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher.AllOf(CommandMatcher.Command, CommandMatcher.CommandConsumed));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.hasCommand && entity.isCommandConsumed;
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var commandEntity in entities)
            {
                commandEntity.isDestroyed = true;
            }
        }

    }
}