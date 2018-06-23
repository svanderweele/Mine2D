using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Time
{
    [Meta, Unique]
    public class TimeServiceComponent : IComponent
    {
        public ITimeService time;

    }
}