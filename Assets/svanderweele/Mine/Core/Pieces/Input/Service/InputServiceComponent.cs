using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.Input.Service
{
    [Meta, Unique]
    public class InputServiceComponent : IComponent
    {
        public IInputService service;
    }
}