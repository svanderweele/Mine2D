using Entitas;
using Entitas.CodeGeneration.Attributes;
using svanderweele.Mine.Core.Pieces.View;

namespace svanderweele.Mine.Core.Services.View
{
    [Meta, Unique]
    public class ViewServiceComponent : IComponent
    {
        public IViewService instance;
    }
}