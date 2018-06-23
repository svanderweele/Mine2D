using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Grid.Core.Components
{
    [Game]
    public class GridLayerComponent : IComponent
    {
        [EntityIndex]
        public int layer;
    }
}