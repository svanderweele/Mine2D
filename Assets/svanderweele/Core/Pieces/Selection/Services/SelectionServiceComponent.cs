using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Selection.Services
{
    [Meta, Unique]
    public class SelectionServiceComponent : IComponent
    {
        public ISelectionService selection;
    }
}