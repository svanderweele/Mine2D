using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Core.Pieces.Tick.Services
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