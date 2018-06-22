using Entitas;

namespace svanderweele.Mine.Core.Pieces.Commands.Components
{
    [Command]
    public class CommandDelayComponent : IComponent
    {
        public float delay;
    }
}