using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Components.Destroy
{
    [Game, Input,Command, Event(true), Grid]
    public class DestroyedComponent : IComponent
    {
        //flag
    }
}