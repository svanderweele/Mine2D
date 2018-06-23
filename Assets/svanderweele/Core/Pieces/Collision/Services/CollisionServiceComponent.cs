using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Collision.Services
{
    [Meta, Unique]
    public class CollisionServiceComponent : IComponent
    {
        public ICollisionService service;
    }
}