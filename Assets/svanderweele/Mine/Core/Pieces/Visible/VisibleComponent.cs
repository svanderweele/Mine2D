using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Pieces.Visible
{ 
    [Game, Event(true)]
    public class VisibleComponent : IComponent
    { 
        public bool isVisible;
    }
}