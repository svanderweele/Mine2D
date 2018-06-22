using Entitas;

namespace svanderweele.Mine.Core.Services.Input.Controller
{
    public class RegisterInputControllerSystem : IInitializeSystem
    {
        private readonly MetaContext _metaContext;
        private readonly IInputController _inputController;

        public RegisterInputControllerSystem(Contexts contexts, IInputController inputController)
        {
            _metaContext = contexts.meta;
            _inputController = inputController;
        }

        public void Initialize()
        {
            _metaContext.ReplaceInputController(_inputController);
        }
    }
}