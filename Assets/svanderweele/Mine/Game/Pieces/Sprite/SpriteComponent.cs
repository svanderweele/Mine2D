using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Pieces.Sprite
{
    [Game, Event(true)]
    public class SpriteComponent : IComponent
    {
        public string name;
    }
}