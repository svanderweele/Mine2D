using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Actions
{
    //TODO : Apply delay before performing action
    [Action]
    public class ActionComponent : IComponent
    {
        public float delay;
    }
}