using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Grid.Core.Components
{
    [Grid, Game]
    public class GridTileTypeComponent : IComponent
    {
        [EntityIndex]
        public string type;
    }
    
}