//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MapEditorEntity {

    static readonly svanderweele.Mine.Core.Pieces.Destroy.DestroyedComponent destroyedComponent = new svanderweele.Mine.Core.Pieces.Destroy.DestroyedComponent();

    public bool isDestroyed {
        get { return HasComponent(MapEditorComponentsLookup.Destroyed); }
        set {
            if (value != isDestroyed) {
                var index = MapEditorComponentsLookup.Destroyed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : destroyedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MapEditorEntity : IDestroyedEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MapEditorMatcher {

    static Entitas.IMatcher<MapEditorEntity> _matcherDestroyed;

    public static Entitas.IMatcher<MapEditorEntity> Destroyed {
        get {
            if (_matcherDestroyed == null) {
                var matcher = (Entitas.Matcher<MapEditorEntity>)Entitas.Matcher<MapEditorEntity>.AllOf(MapEditorComponentsLookup.Destroyed);
                matcher.componentNames = MapEditorComponentsLookup.componentNames;
                _matcherDestroyed = matcher;
            }

            return _matcherDestroyed;
        }
    }
}