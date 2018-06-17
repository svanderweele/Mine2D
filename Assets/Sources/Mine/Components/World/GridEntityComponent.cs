
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game]
public class GridEntityComponent : IComponent
{
    [EntityIndex]
    public int gridEID;
}