using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Game.Actions
{
    public class RemoveActionsSystem : ReactiveSystem<ActionEntity>
    {
        private readonly  ActionContext _actionContext;

        public RemoveActionsSystem(Contexts contexts) : base(contexts.action)
        {
            _actionContext = contexts.action;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher.AllOf(ActionMatcher.Action, ActionMatcher.ActionConsumed));
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.hasAction && entity.isActionConsumed;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                actionEntity.isDestroyed = true;
            }
        }

    }
}