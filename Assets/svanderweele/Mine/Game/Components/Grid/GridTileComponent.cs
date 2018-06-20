using Entitas;

namespace svanderweele.Mine.Game.Components.Grid
{
    [Grid]
    public class GridTileComponent : IComponent
    {
        int[,] tiles;
    }
}