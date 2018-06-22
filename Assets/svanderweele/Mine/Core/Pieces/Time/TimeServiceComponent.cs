using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.Time
{
    [Meta, Unique]
    public class TimeServiceComponent : IComponent
    {
        public ITimeService time;
    }
}