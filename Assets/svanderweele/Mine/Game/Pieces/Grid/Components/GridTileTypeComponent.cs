using Entitas;
using Entitas.CodeGeneration.Attributes;
using svanderweele.Mine.Game.Utils;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Grid, Game]
    public class GridTileTypeComponent : IComponent
    {
        [EntityIndex]
        public string type;
    }
    
}