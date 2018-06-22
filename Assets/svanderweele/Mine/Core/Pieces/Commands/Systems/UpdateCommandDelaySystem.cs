using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.Core.Pieces.Commands.Systems
{
    public class UpdateCommandDelaySystem : ReactiveSystem<CommandEntity>
    {
        private readonly Contexts _contexts;

        public UpdateCommandDelaySystem(Contexts contexts) : base(contexts.command)
        {
            _contexts = contexts;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher.CommandDelay);
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.hasCommandDelay;
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var commandEntity in entities)
            {
                var delay = commandEntity.commandDelay.delay;

                delay -= Time.deltaTime;
                commandEntity.ReplaceCommandDelay(delay);
                if (delay <= 0)
                {
                    commandEntity.RemoveCommandDelay();
                }
            }
        }
    }
}