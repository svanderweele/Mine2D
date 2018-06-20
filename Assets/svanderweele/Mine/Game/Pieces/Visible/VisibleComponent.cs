using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Pieces.Visible
{ 
    [Game, Event(true)]
    public class VisibleComponent : IComponent
    { 
        public bool isVisible;
    }
}