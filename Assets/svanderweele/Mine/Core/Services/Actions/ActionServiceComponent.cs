using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.Actions
{
    [Meta, Unique]
    public class ActionServiceComponent : IComponent
    {
        public IActionService service;
    }
}