using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Event(true)]
public class PositionComponent : IComponent {
    public float x;
    public float y;
}
