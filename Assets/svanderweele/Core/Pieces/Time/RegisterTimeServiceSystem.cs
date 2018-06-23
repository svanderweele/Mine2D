using Entitas;

namespace svanderweele.Core.Pieces.Time
{
    public class RegisterTimeServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ITimeService _time;

        public RegisterTimeServiceSystem(Contexts contexts, ITimeService time)
        {
            _contexts = contexts;
            _time = time;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceTimeService(_time);
        }
    }
}