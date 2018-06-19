using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Services.Actions
{
    [Action]
    public class ActionComponent : IComponent
    {
        [EntityIndex]
        public string value;

        public float delay;
    }
}