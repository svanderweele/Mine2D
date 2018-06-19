using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Components.Destroy
{
    [Game, Input, Action,Command, Event(true)]
    public class DestroyedComponent : IComponent
    {
        //flag
    }
}