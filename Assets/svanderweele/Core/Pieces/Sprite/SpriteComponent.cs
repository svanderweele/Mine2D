using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Sprite
{
    [Game, Event(true)]
    public class SpriteComponent : IComponent
    {
        public string name;
    }
}