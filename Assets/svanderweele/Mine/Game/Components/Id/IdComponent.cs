using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Components.Id
{
    [Game, Input, Meta, Command, Grid]
    public class IdComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int value;
    }
}