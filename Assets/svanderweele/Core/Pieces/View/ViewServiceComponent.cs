using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.View
{
    [Meta, Unique]
    public class ViewServiceComponent : IComponent
    {
        public IViewService instance;
    }
}