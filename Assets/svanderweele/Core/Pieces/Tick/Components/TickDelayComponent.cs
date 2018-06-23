using Entitas;

namespace svanderweele.Core.Pieces.Tick.Components
{
    [Game]
    public class TickDelayComponent : IComponent
    {
        public float delay;
    }
}