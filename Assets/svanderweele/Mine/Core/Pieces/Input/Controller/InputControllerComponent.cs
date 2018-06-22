using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.Input.Controller
{
    //TODO : I don't see the reason to be able to access this publicly
    [Meta, Unique]
    public class InputControllerComponent : IComponent
    {
        public IInputController instance;
    }
}