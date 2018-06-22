﻿using Entitas;
using svanderweele.Mine.Core.Pieces;
using svanderweele.Mine.Core.Pieces.Commands.Systems;
using svanderweele.Mine.Core.Pieces.Destroy;
using svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid;
using svanderweele.Mine.Core.Pieces.Selection.Systems;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Services;
using svanderweele.Mine.GameEditor;
using UnityEngine;

namespace svanderweele.Mine.Game
{
    public class GameSystems : Feature
    {
        public GameSystems(Contexts contexts, CoreServices coreServices, GameServices gameServices, EditorServices editorServices)
        {
            //Initialize
            Add(new RegisterServicesSystem(contexts, coreServices, gameServices, editorServices));

            //Remove
            Add(new RemoveCommandSystem(contexts));

            //Command Requests
            Add(new CommandRequestAddEntityToGridSystem(contexts));

            //Commands
            Add(new CommandAddEntityToGridSystem(contexts));

            //Update
//            Add(new DrawGridDebugSystem(contexts));
//            Add(new GenerateGridSystem(contexts));
            Add(new UpdateCommandDelaySystem(contexts));
            Add(new UpdateSelectionColorSystem(contexts));

            //Events
            Add(new CommandEventSystems(contexts));
            Add(new GameEventSystems(contexts));
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