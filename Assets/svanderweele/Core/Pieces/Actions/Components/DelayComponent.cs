using Entitas;

namespace svanderweele.Core.Pieces.Actions.Components
{
    [Action,Request]
    public class DelayComponent : IComponent
    {
        public float value;
    }
}