using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.View
{
    [Meta, Unique]
    public class ViewServiceComponent : IComponent
    {
        public IViewService instance;
    }
}