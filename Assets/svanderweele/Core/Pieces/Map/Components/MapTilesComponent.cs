using System.Collections.Generic;
using Entitas;

namespace svanderweele.Core.Pieces.Map.Components
{
    [Game]
    public class MapTilesComponent : IComponent
    {
        public Dictionary<int, int[,]> tiles;
    }
}