using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Visible
{ 
    [Game, Event(true)]
    public class VisibleComponent : IComponent
    { 
        public bool isVisible;
    }
}