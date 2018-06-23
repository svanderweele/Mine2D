using System.Collections.Generic;
using Entitas;
using svanderweele.Core.Pieces;
using svanderweele.Core.Pieces.Collision.Services;
using svanderweele.Core.Pieces.Actions;
using svanderweele.Core.Pieces.Grid.Core;
using svanderweele.Core.Pieces.Grid.Core.Service;
using svanderweele.Core.Pieces.Id;
using svanderweele.Core.Pieces.Input.Service;
using svanderweele.Core.Pieces.Selection.Services;
using svanderweele.Core.Pieces.Tick.Components;
using svanderweele.Core.Pieces.Tick.Services;
using svanderweele.Mine.Game.Factories;
using svanderweele.Mine.Game.Factories.Tile;
using svanderweele.Mine.Game.Unity;
using svanderweele.Mine.Game.Utils;
using svanderweele.Mine.GameEditor;
using svanderweele.Mine.GameEditor.Pieces.MapEditor.Services;
using svanderweele.Mine.GameEditor.Unity;
using UnityEngine;
using Vector2 = svanderweele.Mine.Game.Utils.Math.Vector2;
using Vector2Int = svanderweele.Mine.Game.Utils.Math.Vector2Int;
using Color = svanderweele.Mine.Game.Utils.Containers.Color;

namespace svanderweele.Mine.Game
{
    public class Main : MonoBehaviour
    {
        private Contexts _contexts;
        private Systems _systems;
        private CoreServices _coreServices;
        private GameServices _gameServices;
        private EditorServices _editorServices;
        private GameFactories _gameFactories;

        void Awake()
        {
            Application.targetFrameRate = 60;
            _contexts = Contexts.sharedInstance;
            _contexts.SubscribeId();

            _coreServices = new CoreServices(new UnityViewService(), new InputService(_contexts),
                new UnityInputController(new UnityInputMapper()), new CollisionService(_contexts),
                new SelectionService(_contexts), new UnityTimeService(), new TickService(_contexts));

            _gameServices = new GameServices(new GridService(_contexts));

            _editorServices = new EditorServices(new GridEditorService(_contexts, new UnityMapEditorAssetLoader(),
                new GridEditorToolsService(), new GridEditorNavigationService(), new GridEditorObjectService()));

            _gameFactories = new GameFactories(new TileFactory(_contexts));


            _systems = CreateSystems();
            _systems.Initialize();

            var grid = _contexts.grid.CreateGrid(10, 10, 1, 1, ObjectType.OBJECT_CATEGORY_TILE);


            var e = _contexts.game.CreateEntity();
            _coreServices.View.LoadAsset(_contexts, e, GlobalVariables.ResourcesAssetsPath + "prefabs/miner");
            e.AddPosition(-3, 3);
            e.AddVisible(true);
            e.AddSelectionColor(newSelectionDown: new Color(0.0f, 1.0f, 0.0f, 1.0f), newSelectionHeld: new Color(),
                newSelectionHoverIn: new Color(), newSelectionHoverOut: new Color(),
                newSelectionHoverSelect: new Color(), newSelectionUp: new Color());


            var action = _contexts.action.CreateEntity();
            action.AddActionCreateMap(new Vector2Int(10, 10), TileType.Stone, TileType.Stone);
//            var command = new CommandCreateMapEditor(_contexts, grid.id.value);
//            command.DoCommand();

            var tick = _contexts.game.CreateEntity();
            var newTick = new Tick() {delayValue = 0.05f, delay = 1, multiplier = 1f};
            tick.AddTick(new Dictionary<TickEnum, Tick>()
            {
                {
                    TickEnum.MapEditor_AssetLoading, newTick
                }
            });
        }

        private Systems CreateSystems()
        {
            return new Systems()
                .Add(new DebugSystems(_contexts))
                .Add(new GameSystems(_contexts, _coreServices, _gameServices, _editorServices, _gameFactories))
                .Add(new EditorSystems(_contexts));
        }

        void Update()

        {
            if (_coreServices.InputController.IsKeyDown(KeyId.D))
            {
                var grid = _contexts.grid.GetEntityWithId(0);
                grid.isGridChanged = !grid.isGridChanged;
            }

            if (_coreServices.Input.IsKeyDown(KeyId.S))
            {
                var objectB = _contexts.game.CreateEntity();
                _coreServices.View.LoadAsset(_contexts, objectB, "Tile");
                objectB.AddPosition(2, 2);
                objectB.AddVisible(true);
                objectB.AddGridPosition(new Vector2(2, 3));
                objectB.AddGridTileType(GlobalVariables.ObjectType.JoinTypes(ObjectType.OBJECT_CATEGORY_DEBUG,
                    ObjectType.OBJECT_CATEGORY_TILE));
                var reqB = _contexts.action.CreateActionRequest(0);
                reqB.AddActionRequestAddEntityToGrid(objectB.id.value, _contexts.grid.GetEntityWithId(0).id.value,
                    Random.Range(0, 5));
            }

            _systems.Execute();
            _systems.Cleanup();
        }

        void OnDestroy()
        {
            _systems.TearDown();
        }
    }
}