using Entitas;

namespace svanderweele.Core.Pieces.View
{
    public class RegisterViewServiceSystem : IInitializeSystem
    {
        private readonly Contexts contexts;
        private readonly IViewService viewService;

        public RegisterViewServiceSystem(Contexts contexts, IViewService viewService)
        {
            this.contexts = contexts;
            this.viewService = viewService;
        }

        public void Initialize()
        {
            contexts.meta.ReplaceViewService(viewService);
        }
    }
}