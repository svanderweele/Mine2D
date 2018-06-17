using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Event(true)]
public class SpriteComponent : IComponent
{
    public string spriteName;
}