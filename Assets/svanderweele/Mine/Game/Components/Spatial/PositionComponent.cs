using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Components.Spatial
{
    [Game, Event(true)]
    public class PositionComponent : IComponent
    {
        public float x;
        public float y;
    }
}