using Entitas;

namespace svanderweele.Mine.Core.Services.Collision
{
    public class RegisterCollisionServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ICollisionService _collision;

        public RegisterCollisionServiceSystem(Contexts contexts, ICollisionService collision)
        {
            _contexts = contexts;
            _collision = collision;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceCollisionService(_collision);
        }
    }
}