using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.Input
{
    [Meta, Unique]
    public class InputServiceComponent : IComponent
    {
        public IInputService service;
    }
}