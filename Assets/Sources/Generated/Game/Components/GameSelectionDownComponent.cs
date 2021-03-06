//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Core.Pieces.Selection.Components.SelectionDownComponent selectionDown { get { return (svanderweele.Core.Pieces.Selection.Components.SelectionDownComponent)GetComponent(GameComponentsLookup.SelectionDown); } }
    public bool hasSelectionDown { get { return HasComponent(GameComponentsLookup.SelectionDown); } }

    public void AddSelectionDown(float newTimeSinceDown) {
        var index = GameComponentsLookup.SelectionDown;
        var component = CreateComponent<svanderweele.Core.Pieces.Selection.Components.SelectionDownComponent>(index);
        component.timeSinceDown = newTimeSinceDown;
        AddComponent(index, component);
    }

    public void ReplaceSelectionDown(float newTimeSinceDown) {
        var index = GameComponentsLookup.SelectionDown;
        var component = CreateComponent<svanderweele.Core.Pieces.Selection.Components.SelectionDownComponent>(index);
        component.timeSinceDown = newTimeSinceDown;
        ReplaceComponent(index, component);
    }

    public void RemoveSelectionDown() {
        RemoveComponent(GameComponentsLookup.SelectionDown);
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

    static Entitas.IMatcher<GameEntity> _matcherSelectionDown;

    public static Entitas.IMatcher<GameEntity> SelectionDown {
        get {
            if (_matcherSelectionDown == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SelectionDown);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSelectionDown = matcher;
            }

            return _matcherSelectionDown;
        }
    }
}
