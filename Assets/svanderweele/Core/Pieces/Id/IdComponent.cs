using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Id
{
    [Game, Input, Meta, Action, Grid, MapEditor]
    public class IdComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int value;
    }
}