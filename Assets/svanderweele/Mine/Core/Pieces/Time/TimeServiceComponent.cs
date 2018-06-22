using Entitas;
using Entitas.CodeGeneration.Attributes;
using svanderweele.Mine.Core.Pieces.Time;

namespace svanderweele.Mine.Core.Services.Time
{
    [Meta, Unique]
    public class TimeServiceComponent : IComponent
    {
        public ITimeService time;

    }
}