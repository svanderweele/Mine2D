using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.GridEditor.Service.Core
{
    [Meta, Unique]
    public class GridEditorServiceComponent : IComponent
    {
        public IGridEditorService service;
    }
}