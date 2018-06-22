using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.Selection
{
    [Meta, Unique]
    public class SelectionServiceComponent : IComponent
    {
        public ISelectionService selection;
    }
}