using Entitas;
using svanderweele.Mine.Core.Services;
using svanderweele.Mine.Game.Components.Id;
using svanderweele.Mine.Game.Services;
using svanderweele.Mine.Game.Services.Actions;
using svanderweele.Mine.Game.Unity;
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

            _services = new CoreServices(new UnityViewService(), new InputService(_contexts), new ActionService(_contexts));

            _systems = CreateSystems();
            _systems.Initialize();

            var e = _contexts.game.CreateEntity();
            _services.View.LoadAsset(_contexts, e, "Miner");
            e.AddPosition(5, 3);
        }

        private Systems CreateSystems()
        {
            return new Systems()
                .Add(new GameSystems(_contexts, _services));
        }

        void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        void OnDestroy()
        {
            _systems.TearDown();
        }

    }
}

