using Entitas;

namespace svanderweele.Mine.Game.Components.Grid
{
    [Grid]
    public class GridTileSizeComponent : IComponent
    {
        public float tileWidth;
        public float tileHeight;
    }
}