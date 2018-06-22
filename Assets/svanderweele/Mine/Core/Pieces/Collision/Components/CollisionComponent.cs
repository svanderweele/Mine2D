using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Core.Pieces.Collision
{
    [Game]
    public class CollisionComponent : IComponent
    {
        public List<int> collisions;
    }
}