using Entitas;

namespace svanderweele.Mine.Core.Services.Selection
{
    public class RegisterSelectionServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ISelectionService _selection;

        public RegisterSelectionServiceSystem(Contexts contexts, ISelectionService selection)
        {
            _contexts = contexts;
            _selection = selection;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceSelectionService(_selection);
        }
    }
}