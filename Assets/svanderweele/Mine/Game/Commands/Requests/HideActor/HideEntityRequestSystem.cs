using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Game.Commands.Requests.HideActor
{
    public class HideEntityRequestSystem : ReactiveSystem<CommandEntity>
    {
        private Contexts _contexts;

        public HideEntityRequestSystem(Contexts contexts) : base(contexts.command)
        {
            _contexts = contexts;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher.AllOf(CommandMatcher.HideEntityRequest).NoneOf(CommandMatcher.CommandDelay));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.hasHideEntityRequest && entity.isCommandConsumed == false && entity.hasCommandDelay == false;
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                var entity = _contexts.game.GetEntityWithId(actionEntity.hideEntityRequest.entityId);

                if (entity.hasVisible)
                {
                    var cmd = _contexts.command.CreateCommand(0);
                    cmd.AddHideEntityCommand(actionEntity.hideEntityRequest.entityId,
                        actionEntity.hideEntityRequest.visible);
                }

                actionEntity.isCommandConsumed = true;
            }
        }
    }

}