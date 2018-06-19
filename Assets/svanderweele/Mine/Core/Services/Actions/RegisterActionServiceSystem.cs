using Entitas;

namespace svanderweele.Mine.Core.Services.Actions
{
    public class RegisterActionServiceSystem : IInitializeSystem
    {
        private readonly Contexts contexts;
        private readonly IActionService actionService;

        public RegisterActionServiceSystem(Contexts contexts, IActionService actionService)
        {
            this.contexts = contexts;
            this.actionService = actionService;
        }

        public void Initialize()
        {
            contexts.meta.ReplaceActionService(actionService);
        }
    }
}