using System.Collections.Generic;
using Entitas;

namespace svanderweele.Core.Pieces.Actions.Systems
{
    public class RemoveActionSystem : ReactiveSystem<ActionEntity>
    {
        private readonly  ActionContext _actionContext;

        public RemoveActionSystem(Contexts contexts) : base(contexts.action)
        {
            _actionContext = contexts.action;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher.AllOf(ActionMatcher.Action, ActionMatcher.ActionConsumed));
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.isAction && entity.isActionConsumed;
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