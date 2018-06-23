using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Input.Service
{
    [Meta, Unique]
    public class InputServiceComponent : IComponent
    {
        public IInputService service;
    }
}