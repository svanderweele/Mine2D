using Entitas;

namespace svanderweele.Mine.Game.Pieces.Commands.Components
{
    [Command]
    public class CommandDelayComponent : IComponent
    {
        public float delay;
    }
}