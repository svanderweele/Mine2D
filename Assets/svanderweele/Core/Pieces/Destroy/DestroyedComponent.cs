using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Pieces.Destroy
{
    [Game, Input,Action, Grid, MapEditor, Event(true)]
    public class DestroyedComponent : IComponent
    {
        //flag
    }
}