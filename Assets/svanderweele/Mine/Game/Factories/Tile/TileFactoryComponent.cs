using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Factories.Tile
{
    [Factory, Unique]
    public class TileFactoryComponent : IComponent
    {
        public ITileFactory factory;
    }
}