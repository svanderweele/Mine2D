using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Game]
    public class GridLayerComponent : IComponent
    {
        [EntityIndex]
        public int layer;
    }
}