using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Game.Actions
{
    public class HideEntityActionSystem : ReactiveSystem<ActionEntity>
    {
        private Contexts _contexts;

        public HideEntityActionSystem(Contexts contexts) : base(contexts.action)
        {
            _contexts = contexts;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher.HideEntityAction);
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.hasHideEntityAction && entity.isActionConsumed == false;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                var entity = _contexts.game.GetEntityWithId(actionEntity.hideEntityAction.entityId);

                if (entity.hasVisible)
                {
                    //TODO : Create CommandService to create commands
                    var cmd = _contexts.command.CreateEntity();
                    cmd.AddCommand(0);
                    //-----

                    cmd.AddHideEntityCommand(actionEntity.hideEntityAction.entityId,
                        actionEntity.hideEntityAction.visible);
                }

                actionEntity.isActionConsumed = true;
            }
        }
    }

}