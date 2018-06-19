using Entitas;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Components.Destroy;
using svanderweele.Mine.Game.Components.Destroys;
using svanderweele.Mine.Game.Services.Actions;
using svanderweele.Mine.Game.Services.Actions.Systems;

namespace svanderweele.Mine.Game
{
    public class GameSystems : Feature
    {
        public GameSystems(Contexts contexts, CoreServices services)
        {
            
            //Initialize
            Add(new RegisterServicesSystem(contexts, services));

            //Destroy
            Add(new RemoveActionsSystem(contexts));
            
            //Update
            Add(new UpdateActionsSystem(contexts));
            Add(new CallActionsSystem(contexts));

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