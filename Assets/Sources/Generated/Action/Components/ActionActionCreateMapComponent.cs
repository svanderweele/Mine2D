//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity {

    public svanderweele.Mine.MapEditor.Pieces.MapEditor.Actions.CreateMap.ActionCreateMapComponent actionCreateMap { get { return (svanderweele.Mine.MapEditor.Pieces.MapEditor.Actions.CreateMap.ActionCreateMapComponent)GetComponent(ActionComponentsLookup.ActionCreateMap); } }
    public bool hasActionCreateMap { get { return HasComponent(ActionComponentsLookup.ActionCreateMap); } }

    public void AddActionCreateMap(svanderweele.Mine.Game.Utils.Math.Vector2Int newSize, svanderweele.Mine.Game.Factories.Tile.TileType newBackgroundTile, svanderweele.Mine.Game.Factories.Tile.TileType newForegroundTile) {
        var index = ActionComponentsLookup.ActionCreateMap;
        var component = CreateComponent<svanderweele.Mine.MapEditor.Pieces.MapEditor.Actions.CreateMap.ActionCreateMapComponent>(index);
        component.size = newSize;
        component.BackgroundTile = newBackgroundTile;
        component.ForegroundTile = newForegroundTile;
        AddComponent(index, component);
    }

    public void ReplaceActionCreateMap(svanderweele.Mine.Game.Utils.Math.Vector2Int newSize, svanderweele.Mine.Game.Factories.Tile.TileType newBackgroundTile, svanderweele.Mine.Game.Factories.Tile.TileType newForegroundTile) {
        var index = ActionComponentsLookup.ActionCreateMap;
        var component = CreateComponent<svanderweele.Mine.MapEditor.Pieces.MapEditor.Actions.CreateMap.ActionCreateMapComponent>(index);
        component.size = newSize;
        component.BackgroundTile = newBackgroundTile;
        component.ForegroundTile = newForegroundTile;
        ReplaceComponent(index, component);
    }

    public void RemoveActionCreateMap() {
        RemoveComponent(ActionComponentsLookup.ActionCreateMap);
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
public sealed partial class ActionMatcher {

    static Entitas.IMatcher<ActionEntity> _matcherActionCreateMap;

    public static Entitas.IMatcher<ActionEntity> ActionCreateMap {
        get {
            if (_matcherActionCreateMap == null) {
                var matcher = (Entitas.Matcher<ActionEntity>)Entitas.Matcher<ActionEntity>.AllOf(ActionComponentsLookup.ActionCreateMap);
                matcher.componentNames = ActionComponentsLookup.componentNames;
                _matcherActionCreateMap = matcher;
            }

            return _matcherActionCreateMap;
        }
    }
}
