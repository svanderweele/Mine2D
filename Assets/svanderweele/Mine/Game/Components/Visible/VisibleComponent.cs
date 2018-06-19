using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Components.Visible
{ 
    [Game, Event(true)]
    public class VisibleComponent : IComponent
    { 
        public bool isVisible;
    }
}