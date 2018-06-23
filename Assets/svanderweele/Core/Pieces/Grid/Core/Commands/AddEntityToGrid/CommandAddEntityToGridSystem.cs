using System.Collections.Generic;
using Entitas;

namespace svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid
{
    public class ActionAddEntityToGridSystem : ReactiveSystem<ActionEntity>
    {
        private readonly Contexts _contexts;

        public ActionAddEntityToGridSystem(Contexts contexts) : base(contexts.action)
        {
            _contexts = contexts;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher
                .AllOf(ActionMatcher.Action,
                    ActionMatcher.ActionAddEntityToGrid)
                .NoneOf(ActionMatcher.ActionDelay, ActionMatcher.ActionConsumed));
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.isAction && entity.isDestroyed == false && entity.isActionConsumed == false;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                var layer = actionEntity.actionAddEntityToGrid.layer;
                var entity = _contexts.game.GetEntityWithId(actionEntity.actionAddEntityToGrid.entityId);
                entity.AddGridLayer(layer);
                actionEntity.isActionConsumed = true;
            }
        }
    }
}