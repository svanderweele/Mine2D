using Entitas;

namespace svanderweele.Mine.Core.Pieces.GridEditor.Service
{
    public class RegisterGridEditorServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly IGridEditorService _gridEditorService;

        public RegisterGridEditorServiceSystem(Contexts contexts, IGridEditorService gridEditorService)
        {
            _contexts = contexts;
            _gridEditorService = gridEditorService;
        }
        public void Initialize()
        {
            _contexts.meta.ReplaceGridEditorService(_gridEditorService);
        }
    }
}