using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Game.Commands.HideActor
{
    public class HideEntityCommandSystem : ReactiveSystem<CommandEntity>
    {
        private readonly Contexts _contexts;

        public HideEntityCommandSystem(Contexts contexts) : base(contexts.command)
        {
            _contexts = contexts;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher.AllOf(CommandMatcher.HideEntityCommand).NoneOf(CommandMatcher.CommandDelay));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.hasHideEntityCommand && entity.isCommandConsumed == false && entity.hasCommandDelay == false;
            
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var commandEntity in entities)
            {
                var targetEntity = _contexts.game.GetEntityWithId(commandEntity.hideEntityCommand.entityId);
                targetEntity.ReplaceVisible(commandEntity.hideEntityCommand.visible);
                commandEntity.isCommandConsumed = true;
            }
        }
    }
}