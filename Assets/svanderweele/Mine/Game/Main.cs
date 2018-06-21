using Entitas;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Commands;
using svanderweele.Mine.Game.Pieces.Grid;
using svanderweele.Mine.Game.Pieces.Grid.Service;
using svanderweele.Mine.Game.Pieces.Id;
using svanderweele.Mine.Game.Services;
using svanderweele.Mine.Game.Unity;
using svanderweele.Mine.Game.Utils;
using UnityEngine;

namespace svanderweele.Mine.Game
{
    public class Main : MonoBehaviour
    {
        private Contexts _contexts;
        private Systems _systems;
        private CoreServices _services;

        void Awake()
        {
            _contexts = Contexts.sharedInstance;
            _contexts.SubscribeId();

            _services = new CoreServices(new UnityViewService(), new InputService(_contexts),
                new UnityInputController(new UnityInputMapper()), new GridService(_contexts), new CollisionService(_contexts));

            _systems = CreateSystems();
            _systems.Initialize();

            var grid = _contexts.grid.CreateGrid(10, 10, 1, 1, ObjectType.OBJECT_CATEGORY_TILE);

            var objectA = _contexts.game.CreateEntity();
            _services.View.LoadAsset(_contexts, objectA, "Tile");
            objectA.AddPosition(2,2);
            objectA.AddVisible(true);
            objectA.AddGridLayer(0);

            var req = _contexts.command.CreateCommandRequest(0);
            req.AddCommandRequestAddEntityToGrid(objectA.id.value, grid.id.value);
            
            var objectB = _contexts.game.CreateEntity();
            _services.View.LoadAsset(_contexts, objectB, "Tile");
            objectB.AddPosition(2,2);
            objectB.AddVisible(true);
            objectB.AddGridLayer(0);

            var reqB = _contexts.command.CreateCommandRequest(0);
            reqB.AddCommandRequestAddEntityToGrid(objectB.id.value, grid.id.value);
            

//            var e = _contexts.game.CreateEntity();
//            _services.View.LoadAsset(_contexts, e, "Miner");
//            e.AddPosition(5, 3);
//            e.AddVisible(true);
        }

        private Systems CreateSystems()
        {
            return new Systems()
                .Add(new GameSystems(_contexts, _services));
        }

        void Update()
        {
            if (_services.Input.IsKeyBindDown(GlobalVariables.ACTION_HIDE_ACTOR))
            {
                var command = _contexts.command.CreateCommandRequest(5);
                var e = _contexts.game.GetEntityWithId(0);
                command.AddHideEntityRequest(0, !e.visible.isVisible);
            }

            if (_services.InputController.IsKeyDown(KeyId.D))
            {
                var grid = _contexts.grid.GetEntityWithId(0);
                grid.isGridChanged = !grid.isGridChanged;
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