using System.Collections.Generic;
using Entitas;
using svanderweele.Core.Pieces.Tick.Components;

namespace svanderweele.Core.Pieces.Tick.Services
{
    public class TickService : ITickService
    {
        private readonly Contexts _contexts;

        public TickService(Contexts contexts)
        {
            _contexts = contexts;
        }

        public bool IsTick(ITickableEntity entity, TickEnum tickEnum)
        {
            return entity.tick.ticks[tickEnum].shouldTick;
        }

        public void SetFrozenState(ITickableEntity entity, TickEnum tickEnum, bool state)
        {
            var tick = entity.tick.ticks[tickEnum];
            tick.frozen = state;
            entity.ReplaceTick(entity.tick.ticks);
        }

        public void SetValue(ITickableEntity entity, TickEnum tickEnum, float value)
        {
            var tick = entity.tick.ticks[tickEnum];
            tick.currentValue = value;
            tick.value = value;
            entity.ReplaceTick(entity.tick.ticks);
        }

        public void SetDelay(ITickableEntity entity, TickEnum tickEnum, float delay)
        {
            var tick = entity.tick.ticks[tickEnum];
            tick.delay = delay;
            tick.delayValue = delay;
            entity.ReplaceTick(entity.tick.ticks);
        }

        public void ResetDelay(ITickableEntity entity, TickEnum tickEnum)
        {
            var tick = entity.tick.ticks[tickEnum];
            SetDelay(entity, tickEnum, tick.delay);
        }
    }

}


public interface ITickableEntity : IEntity, ITickEntity
{
}

public partial class GameEntity : ITickableEntity
{
}

public partial class MapEditorEntity : ITickableEntity
{
}