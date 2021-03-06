//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Core.Pieces.Map.Components.MapTilesComponent mapTiles { get { return (svanderweele.Core.Pieces.Map.Components.MapTilesComponent)GetComponent(GameComponentsLookup.MapTiles); } }
    public bool hasMapTiles { get { return HasComponent(GameComponentsLookup.MapTiles); } }

    public void AddMapTiles(System.Collections.Generic.Dictionary<int, int[,]> newTiles) {
        var index = GameComponentsLookup.MapTiles;
        var component = CreateComponent<svanderweele.Core.Pieces.Map.Components.MapTilesComponent>(index);
        component.tiles = newTiles;
        AddComponent(index, component);
    }

    public void ReplaceMapTiles(System.Collections.Generic.Dictionary<int, int[,]> newTiles) {
        var index = GameComponentsLookup.MapTiles;
        var component = CreateComponent<svanderweele.Core.Pieces.Map.Components.MapTilesComponent>(index);
        component.tiles = newTiles;
        ReplaceComponent(index, component);
    }

    public void RemoveMapTiles() {
        RemoveComponent(GameComponentsLookup.MapTiles);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMapTiles;

    public static Entitas.IMatcher<GameEntity> MapTiles {
        get {
            if (_matcherMapTiles == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MapTiles);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMapTiles = matcher;
            }

            return _matcherMapTiles;
        }
    }
}
