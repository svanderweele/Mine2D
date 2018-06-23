using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Pieces.Destroy
{
    [Game, Input,Command, Grid, MapEditor, Event(true)]
    public class DestroyedComponent : IComponent
    {
        //flag
    }
}