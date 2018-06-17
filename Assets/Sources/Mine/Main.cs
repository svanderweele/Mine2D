using System;
using Entitas;
using UnityEngine;

public class Main : MonoBehaviour
{

    private Contexts _contexts;
    private Systems _systems;

    private Services _services;

    void Awake()
    {
        _services = new Services(new UnityViewService(), new InputService());
        _contexts = Contexts.sharedInstance;
        _contexts.SubscribeId();
        _systems = CreateSystems();
        _systems.Initialize();


        var e = _contexts.game.CreateEntity();
        _services.View.LoadAsset(_contexts, e, "Miner");
        e.AddPosition(5, 5);
    }

    private Systems CreateSystems()
    {
        return new Systems()
            .Add(new RegisterServicesSystem(_contexts, _services))
            .Add(new GameEventSystems(_contexts))
            .Add(new DestroySystems(_contexts))
            ;
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