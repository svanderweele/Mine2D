using Entitas;

public class DestroyInputEntitiesSystem : IExecuteSystem
{
    private readonly Contexts _contexts;

    public DestroyInputEntitiesSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        var inputEntities = _contexts.input.GetGroup(InputMatcher.InteractionInput);

        foreach(InputEntity e in inputEntities)
        {
            e.isDestroyed = true;
        }
    }
}