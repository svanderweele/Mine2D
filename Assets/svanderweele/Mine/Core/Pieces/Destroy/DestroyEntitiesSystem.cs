using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Core.Pieces.Destroy
{
    public class DestroyEntitiesSystem : MultiReactiveSystem<IDestroyEntity, Contexts>
    {
        private readonly Contexts _contexts;

        public DestroyEntitiesSystem(Contexts contexts) : base(contexts)
        {
            _contexts = contexts;
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[]
            {
                contexts.game.CreateCollector(GameMatcher.Destroyed),
                contexts.input.CreateCollector(InputMatcher.Destroyed),
                contexts.grid.CreateCollector(GridMatcher.Destroyed),
                contexts.command.CreateCollector(CommandMatcher.Destroyed)
            };
        }

        protected override bool Filter(IDestroyEntity entity)
        {
            return entity.isDestroyed;
        }

        protected override void Execute(List<IDestroyEntity> entities)
        {
            foreach (var destroyEntity in entities)
            {
                destroyEntity.Destroy();
            }
        }
    }
}

//If these give you problems, you probably updated the namespace, take them out of the scope and it'll solve it
public interface IDestroyEntity : IEntity, IDestroyedEntity
{
}

public partial class GameEntity : IDestroyEntity
{
}

public partial class InputEntity : IDestroyEntity
{
}

public partial class GridEntity : IDestroyEntity
{
}

public partial class CommandEntity : IDestroyEntity
{
}