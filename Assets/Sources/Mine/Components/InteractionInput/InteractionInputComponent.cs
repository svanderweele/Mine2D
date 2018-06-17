
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Input]
public class InteractionInputComponent : IComponent
{
    [PrimaryEntityIndex]
    public int eId;
}
