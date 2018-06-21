using Entitas;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Commands;
using svanderweele.Mine.Game.Commands.HideActor;
using svanderweele.Mine.Game.Commands.Requests.HideActor;
using svanderweele.Mine.Game.Pieces.Destroy;
using svanderweele.Mine.Game.Pieces.Grid.Commands.AddEntityToGrid;
using svanderweele.Mine.Game.Pieces.Grid.Service;
using svanderweele.Mine.Game.Pieces.Grid.Systems;

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
            
            //Command Requests
            Add(new CommandRequestAddEntityToGridSystem(contexts));

            //Commands
            
            //Update
//            Add(new DrawGridDebugSystem(contexts));
//            Add(new GenerateGridSystem(contexts));
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