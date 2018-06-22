using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Core.Pieces.Tick.Systems
{
    public class ResetTickSystem : ReactiveSystem<GameEntity>
    {
        public ResetTickSystem(IContext<GameEntity> context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            throw new System.NotImplementedException();
        }

        protected override bool Filter(GameEntity entity)
        {
            throw new System.NotImplementedException();
        }

        protected override void Execute(List<GameEntity> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}