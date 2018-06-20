using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Grid]
    public class GridTileComponent : IComponent
    {
        int[,] tiles;
    }
}