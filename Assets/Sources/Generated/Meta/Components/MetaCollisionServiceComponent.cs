//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaContext {

    public MetaEntity collisionServiceEntity { get { return GetGroup(MetaMatcher.CollisionService).GetSingleEntity(); } }
    public svanderweele.Core.Pieces.Collision.Services.CollisionServiceComponent collisionService { get { return collisionServiceEntity.collisionService; } }
    public bool hasCollisionService { get { return collisionServiceEntity != null; } }

    public MetaEntity SetCollisionService(svanderweele.Core.Pieces.Collision.Services.ICollisionService newService) {
        if (hasCollisionService) {
            throw new Entitas.EntitasException("Could not set CollisionService!\n" + this + " already has an entity with svanderweele.Core.Pieces.Collision.Services.CollisionServiceComponent!",
                "You should check if the context already has a collisionServiceEntity before setting it or use context.ReplaceCollisionService().");
        }
        var entity = CreateEntity();
        entity.AddCollisionService(newService);
        return entity;
    }

    public void ReplaceCollisionService(svanderweele.Core.Pieces.Collision.Services.ICollisionService newService) {
        var entity = collisionServiceEntity;
        if (entity == null) {
            entity = SetCollisionService(newService);
        } else {
            entity.ReplaceCollisionService(newService);
        }
    }

    public void RemoveCollisionService() {
        collisionServiceEntity.Destroy();
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

    public svanderweele.Core.Pieces.Collision.Services.CollisionServiceComponent collisionService { get { return (svanderweele.Core.Pieces.Collision.Services.CollisionServiceComponent)GetComponent(MetaComponentsLookup.CollisionService); } }
    public bool hasCollisionService { get { return HasComponent(MetaComponentsLookup.CollisionService); } }

    public void AddCollisionService(svanderweele.Core.Pieces.Collision.Services.ICollisionService newService) {
        var index = MetaComponentsLookup.CollisionService;
        var component = CreateComponent<svanderweele.Core.Pieces.Collision.Services.CollisionServiceComponent>(index);
        component.service = newService;
        AddComponent(index, component);
    }

    public void ReplaceCollisionService(svanderweele.Core.Pieces.Collision.Services.ICollisionService newService) {
        var index = MetaComponentsLookup.CollisionService;
        var component = CreateComponent<svanderweele.Core.Pieces.Collision.Services.CollisionServiceComponent>(index);
        component.service = newService;
        ReplaceComponent(index, component);
    }

    public void RemoveCollisionService() {
        RemoveComponent(MetaComponentsLookup.CollisionService);
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

    static Entitas.IMatcher<MetaEntity> _matcherCollisionService;

    public static Entitas.IMatcher<MetaEntity> CollisionService {
        get {
            if (_matcherCollisionService == null) {
                var matcher = (Entitas.Matcher<MetaEntity>)Entitas.Matcher<MetaEntity>.AllOf(MetaComponentsLookup.CollisionService);
                matcher.componentNames = MetaComponentsLookup.componentNames;
                _matcherCollisionService = matcher;
            }

            return _matcherCollisionService;
        }
    }
}
