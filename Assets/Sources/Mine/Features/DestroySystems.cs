public class DestroySystems : Feature
{
    public DestroySystems(Contexts contexts) : base("Destroy Systems")
    {
        Add(new DestroyInputEntitiesSystem(contexts));
        Add(new DestroyEntitiesSystem(contexts));
    }
}