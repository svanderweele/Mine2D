

using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Meta]
public class EIDComponent : IComponent
{
    [PrimaryEntityIndex]
    public int value;
}