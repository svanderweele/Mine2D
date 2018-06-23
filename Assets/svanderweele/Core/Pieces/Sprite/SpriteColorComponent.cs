using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Sprite
{
    [Game, Event(true)]
    public class SpriteColorComponent : IComponent
    {
        public float r;
        public float g;
        public float b;
        public float a;
    }
}