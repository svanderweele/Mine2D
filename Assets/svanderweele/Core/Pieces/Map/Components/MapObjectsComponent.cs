using System.Collections.Generic;
using Entitas;

namespace svanderweele.Core.Pieces.Map.Components
{
    [Game]
    public class MapObjectsComponent : IComponent
    {
        public List<int> objects;
    }
}