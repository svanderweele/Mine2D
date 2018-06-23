using System.Collections.Generic;
using Entitas;

namespace svanderweele.Core.Pieces.Actions.Systems
{
    public class UpdateActionDelaySystem : ReactiveSystem<ActionEntity>
    {
        private readonly Contexts _contexts;

        public UpdateActionDelaySystem(Contexts contexts) : base(contexts.action)
        {
            _contexts = contexts;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher.Delay);
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.hasDelay;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                var delay = actionEntity.delay.value;

                delay -= _contexts.meta.timeService.time.GetDeltaTime();
                actionEntity.ReplaceDelay(delay);
                if (delay <= 0)
                {
                    actionEntity.RemoveDelay();
                }
            }
        }
    }
}