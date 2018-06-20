using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Grid]
    public class GridTileSizeComponent : IComponent
    {
        public float tileWidth;
        public float tileHeight;
    }
}