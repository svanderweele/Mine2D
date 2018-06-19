using System.Collections.Generic;
using Entitas;
using svanderweele.Mine.Core.Services.Actions;
using UnityEngine;

namespace svanderweele.Mine.Game.Services.Actions
{
    public class CallActionsSystem : ReactiveSystem<ActionEntity>
    {
        private IActionService _actionService;

        public CallActionsSystem(Contexts contexts) : base(contexts.action)
        {
            _actionService = contexts.meta.actionService.service;
        }


        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher.Action);
        }


        protected override bool Filter(ActionEntity entity)
        {
            return entity.hasAction && entity.isDestroyed == false;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                var delay = actionEntity.action.delay;

                if (delay <= 0)
                {
                    _actionService.CallAction(actionEntity.action.value);
                }
            }
        }
    }
}