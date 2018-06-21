using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Game.Commands
{
    public class RemoveCommandSystem : ReactiveSystem<CommandEntity>
    {
        private readonly  CommandContext _actionContext;

        public RemoveCommandSystem(Contexts contexts) : base(contexts.command)
        {
            _actionContext = contexts.command;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher.AllOf(CommandMatcher.Command, CommandMatcher.CommandConsumed));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.isCommand && entity.isCommandConsumed;
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