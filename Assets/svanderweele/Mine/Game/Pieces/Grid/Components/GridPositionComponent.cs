using Entitas;
using Entitas.CodeGeneration.Attributes;
using svanderweele.Mine.Game.Utils.Math;

namespace svanderweele.Mine.Game.Pieces.Grid.Components
{
    [Game]
    public class GridPositionComponent : IComponent
    {
        [EntityIndex] public Vector2 position;
    }
}