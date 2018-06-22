using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Pieces.Sprite
{
    [Game, Event(true)]
    public class SpriteComponent : IComponent
    {
        public string name;
    }
}