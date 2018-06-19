using Entitas;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Actions;
using svanderweele.Mine.Game.Commands.HideActor;
using svanderweele.Mine.Game.Components.Destroy;
using RemoveActionsSystem = svanderweele.Mine.Game.Actions.RemoveActionsSystem;

namespace svanderweele.Mine.Game
{
    public class GameSystems : Feature
    {
        public GameSystems(Contexts contexts, CoreServices services)
        {
            
            //Initialize
            Add(new RegisterServicesSystem(contexts, services));

            //Remove
            Add(new RemoveActionsSystem(contexts));
            Add(new RemoveCommandsSystem(contexts));
            
            //Update
            Add(new HideEntityActionSystem(contexts));
            Add(new HideEntityCommandSystem(contexts));
            
            //Events
            Add(new ActionEventSystems(contexts));
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