
using Entitas;
using svanderweele.Core.Pieces.Map.Data;

namespace svanderweele.Core.Pieces.Map.Components
{
    [Game]
    public class MapDataComponent : IComponent
    {
        public MapData data;
    }
}