using System.Collections.Generic;
using Entitas;

public interface IDestroyEntity : IEntity, IDestroyedEntity { }
public partial class GameEntity : IDestroyEntity{}
public partial class InputEntity : IDestroyEntity{}
public partial class ActionEntity : IDestroyEntity{}
public partial class CommandEntity : IDestroyEntity{}

namespace svanderweele.Mine.Game.Components.Destroy
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
                contexts.action.CreateCollector(ActionMatcher.Destroyed),
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