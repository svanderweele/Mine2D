using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Pieces.GridEditor.Service
{
    [Meta, Unique]
    public class GridEditorServiceComponent : IComponent
    {
        public IGridEditorService service;
    }
}