//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Mine.Core.Pieces.Selection.Components.SelectionOverComponent selectionOver { get { return (svanderweele.Mine.Core.Pieces.Selection.Components.SelectionOverComponent)GetComponent(GameComponentsLookup.SelectionOver); } }
    public bool hasSelectionOver { get { return HasComponent(GameComponentsLookup.SelectionOver); } }

    public void AddSelectionOver(float newTimeSinceOver) {
        var index = GameComponentsLookup.SelectionOver;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Selection.Components.SelectionOverComponent>(index);
        component.timeSinceOver = newTimeSinceOver;
        AddComponent(index, component);
    }

    public void ReplaceSelectionOver(float newTimeSinceOver) {
        var index = GameComponentsLookup.SelectionOver;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Selection.Components.SelectionOverComponent>(index);
        component.timeSinceOver = newTimeSinceOver;
        ReplaceComponent(index, component);
    }

    public void RemoveSelectionOver() {
        RemoveComponent(GameComponentsLookup.SelectionOver);
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

    static Entitas.IMatcher<GameEntity> _matcherSelectionOver;

    public static Entitas.IMatcher<GameEntity> SelectionOver {
        get {
            if (_matcherSelectionOver == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SelectionOver);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSelectionOver = matcher;
            }

            return _matcherSelectionOver;
        }
    }
}
