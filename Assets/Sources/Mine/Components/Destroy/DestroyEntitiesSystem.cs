using System.Collections.Generic;
using Entitas;

public interface IDestroyEntity : IEntity, IDestroyedEntity { }

public partial class GameEntity : IDestroyedEntity { }
public partial class InputEntity : IDestroyedEntity { }

public class DestroyEntitiesSystem : MultiReactiveSystem<IDestroyEntity, Contexts>
{
    private readonly Contexts contexts;

    public DestroyEntitiesSystem(Contexts contexts) : base(contexts)
    {
        this.contexts = contexts;
    }


    protected override bool Filter(IDestroyEntity entity)
    {
        return entity.isDestroyed;
    }

    protected override ICollector[] GetTrigger(Contexts contexts)
    {
        return new ICollector[]
        {
            contexts.game.CreateCollector(GameMatcher.Destroyed),
            contexts.input.CreateCollector(InputMatcher.Destroyed)
        };
    }


    protected override void Execute(List<IDestroyEntity> entities)
    {
        foreach(var e in entities)
        {
            e.Destroy();
        }
    }

}