using Entitas;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Components.Destroy;
namespace svanderweele.Mine.Game
{
    public class GameSystems : Feature
    {
        public GameSystems(Contexts contexts, CoreServices services)
        {
            
            //Initialize
            Add(new RegisterServicesSystem(contexts, services));

            //Destroy
            
            //Update

            //View

            Add(new GameEventSystems(contexts));
            
            //Cleanup
            Add(new DestroyEntitiesSystem(contexts));
        }

        public sealed override Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}