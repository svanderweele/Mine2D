using Entitas;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Commands;
using svanderweele.Mine.Game.Commands.HideActor;
using svanderweele.Mine.Game.Commands.Requests.HideActor;
using svanderweele.Mine.Game.Components.Destroy;

namespace svanderweele.Mine.Game
{
    public class GameSystems : Feature
    {
        public GameSystems(Contexts contexts, CoreServices services)
        {
            
            //Initialize
            Add(new RegisterServicesSystem(contexts, services));

            //Remove
            Add(new RemoveCommandSystem(contexts));
            
            //Update
            Add(new UpdateCommandDelaySystem(contexts));
            Add(new HideEntityRequestSystem(contexts));
            Add(new HideEntityCommandSystem(contexts));
 
            //Events
            Add(new CommandEventSystems(contexts));
            Add(new GameEventSystems(contexts));
            Add(new InputEventSystems(contexts));
            
            //Cleanup
            Add(new DestroyEntitiesSystem(contexts));
        }

        public sealed override Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}