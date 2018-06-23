using Entitas;

namespace svanderweele.Core.Pieces.Input.Service
{
    public class RegisterInputServiceSystem : IInitializeSystem
    {
        private readonly MetaContext _metaContext;
        private readonly IInputService _service;

        public RegisterInputServiceSystem(Contexts contexts, IInputService service)
        {
            _metaContext = contexts.meta;
            _service = service;
        }
        
        public void Initialize()
        {
            _metaContext.ReplaceInputService(_service);
        }
    }
}