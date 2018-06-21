using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Services.Collision
{
    [Meta, Unique]
    public class CollisionServiceComponent : IComponent
    {
        public ICollisionService service;
    }
}