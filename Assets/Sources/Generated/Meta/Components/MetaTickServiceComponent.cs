//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaContext {

    public MetaEntity tickServiceEntity { get { return GetGroup(MetaMatcher.TickService).GetSingleEntity(); } }
    public svanderweele.Mine.Core.Pieces.Tick.Services.TickServiceComponent tickService { get { return tickServiceEntity.tickService; } }
    public bool hasTickService { get { return tickServiceEntity != null; } }

    public MetaEntity SetTickService(svanderweele.Mine.Core.Pieces.Tick.Services.ITickService newInstance) {
        if (hasTickService) {
            throw new Entitas.EntitasException("Could not set TickService!\n" + this + " already has an entity with svanderweele.Mine.Core.Pieces.Tick.Services.TickServiceComponent!",
                "You should check if the context already has a tickServiceEntity before setting it or use context.ReplaceTickService().");
        }
        var entity = CreateEntity();
        entity.AddTickService(newInstance);
        return entity;
    }

    public void ReplaceTickService(svanderweele.Mine.Core.Pieces.Tick.Services.ITickService newInstance) {
        var entity = tickServiceEntity;
        if (entity == null) {
            entity = SetTickService(newInstance);
        } else {
            entity.ReplaceTickService(newInstance);
        }
    }

    public void RemoveTickService() {
        tickServiceEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaEntity {

    public svanderweele.Mine.Core.Pieces.Tick.Services.TickServiceComponent tickService { get { return (svanderweele.Mine.Core.Pieces.Tick.Services.TickServiceComponent)GetComponent(MetaComponentsLookup.TickService); } }
    public bool hasTickService { get { return HasComponent(MetaComponentsLookup.TickService); } }

    public void AddTickService(svanderweele.Mine.Core.Pieces.Tick.Services.ITickService newInstance) {
        var index = MetaComponentsLookup.TickService;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Tick.Services.TickServiceComponent>(index);
        component.instance = newInstance;
        AddComponent(index, component);
    }

    public void ReplaceTickService(svanderweele.Mine.Core.Pieces.Tick.Services.ITickService newInstance) {
        var index = MetaComponentsLookup.TickService;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Tick.Services.TickServiceComponent>(index);
        component.instance = newInstance;
        ReplaceComponent(index, component);
    }

    public void RemoveTickService() {
        RemoveComponent(MetaComponentsLookup.TickService);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MetaMatcher {

    static Entitas.IMatcher<MetaEntity> _matcherTickService;

    public static Entitas.IMatcher<MetaEntity> TickService {
        get {
            if (_matcherTickService == null) {
                var matcher = (Entitas.Matcher<MetaEntity>)Entitas.Matcher<MetaEntity>.AllOf(MetaComponentsLookup.TickService);
                matcher.componentNames = MetaComponentsLookup.componentNames;
                _matcherTickService = matcher;
            }

            return _matcherTickService;
        }
    }
}