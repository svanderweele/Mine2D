using Entitas;
using Entitas.CodeGeneration.Attributes;

[Meta, Unique]
public class GridServiceComponent : IComponent
{
    public IGridService instance;
}