using System.Collections.Generic;
using Entitas;

namespace svanderweele.Core.Pieces.Collision.Components
{
    [Game]
    public class CollisionComponent : IComponent
    {
        public List<int> collisions;
    }
}