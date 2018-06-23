using Entitas;
using svanderweele.Core.Pieces;
using svanderweele.Core.Pieces.Actions.Systems;
using svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid;
using svanderweele.Core.Pieces.Selection.Systems;
using svanderweele.Core.Pieces.Tick.Systems;
using svanderweele.Mine.Core.Pieces;
using svanderweele.Mine.Core.Pieces.Destroy;
using svanderweele.Mine.GameEditor;
using UnityEngine;

namespace svanderweele.Mine.Game
{
    public class GameSystems : Feature
    {
        public GameSystems(Contexts contexts, CoreServices coreServices, GameServices gameServices,
            EditorServices editorServices)
        {
            //Initialize
            Add(new RegisterServicesSystem(contexts, coreServices, gameServices, editorServices));

            //Remove
            Add(new RemoveActionSystem(contexts));

            //Action Requests
            Add(new ActionRequestAddEntityToGridSystem(contexts));

            //Actions
            Add(new ActionAddEntityToGridSystem(contexts));

            //Update
            Add(new UpdateActionDelaySystem(contexts));
            Add(new UpdateSelectionColorSystem(contexts));
            Add(new UpdateTickSystem(contexts));

            //Events
            Add(new ActionEventSystems(contexts));
            Add(new GameEventSystems(contexts));
            Add(new MapEditorEventSystems(contexts));
            Add(new InputEventSystems(contexts));

            //Cleanup
            Add(new CoreServiceCleanupSystems(contexts));
            Add(new DestroyEntitiesSystem(contexts));
        }

        public sealed override Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}