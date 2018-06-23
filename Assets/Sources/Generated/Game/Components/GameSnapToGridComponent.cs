//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Core.Pieces.Spatial.SnapToGridComponent snapToGrid { get { return (svanderweele.Core.Pieces.Spatial.SnapToGridComponent)GetComponent(GameComponentsLookup.SnapToGrid); } }
    public bool hasSnapToGrid { get { return HasComponent(GameComponentsLookup.SnapToGrid); } }

    public void AddSnapToGrid(int newX, int newY) {
        var index = GameComponentsLookup.SnapToGrid;
        var component = CreateComponent<svanderweele.Core.Pieces.Spatial.SnapToGridComponent>(index);
        component.x = newX;
        component.y = newY;
        AddComponent(index, component);
    }

    public void ReplaceSnapToGrid(int newX, int newY) {
        var index = GameComponentsLookup.SnapToGrid;
        var component = CreateComponent<svanderweele.Core.Pieces.Spatial.SnapToGridComponent>(index);
        component.x = newX;
        component.y = newY;
        ReplaceComponent(index, component);
    }

    public void RemoveSnapToGrid() {
        RemoveComponent(GameComponentsLookup.SnapToGrid);
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

    static Entitas.IMatcher<GameEntity> _matcherSnapToGrid;

    public static Entitas.IMatcher<GameEntity> SnapToGrid {
        get {
            if (_matcherSnapToGrid == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SnapToGrid);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSnapToGrid = matcher;
            }

            return _matcherSnapToGrid;
        }
    }
}
