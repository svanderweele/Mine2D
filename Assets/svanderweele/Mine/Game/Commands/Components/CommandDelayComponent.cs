using Entitas;

namespace svanderweele.Mine.Game.Commands
{
    [Command]
    public class CommandDelayComponent : IComponent
    {
        public float delay;
    }
}