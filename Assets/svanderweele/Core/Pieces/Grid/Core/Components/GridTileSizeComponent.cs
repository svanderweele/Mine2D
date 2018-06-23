using Entitas;

namespace svanderweele.Core.Pieces.Grid.Core.Components
{
    [Grid]
    public class GridTileSizeComponent : IComponent
    {
        public float tileWidth;
        public float tileHeight;
    }
}