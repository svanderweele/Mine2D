using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Commands
{
    //TODO : Apply delay before performing command

    [Command]
    public class CommandComponent : IComponent
    {
        public float delay;
    }
}