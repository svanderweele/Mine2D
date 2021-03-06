//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Core.Pieces.Tick.Components.TickDelayComponent tickDelay { get { return (svanderweele.Core.Pieces.Tick.Components.TickDelayComponent)GetComponent(GameComponentsLookup.TickDelay); } }
    public bool hasTickDelay { get { return HasComponent(GameComponentsLookup.TickDelay); } }

    public void AddTickDelay(float newDelay) {
        var index = GameComponentsLookup.TickDelay;
        var component = CreateComponent<svanderweele.Core.Pieces.Tick.Components.TickDelayComponent>(index);
        component.delay = newDelay;
        AddComponent(index, component);
    }

    public void ReplaceTickDelay(float newDelay) {
        var index = GameComponentsLookup.TickDelay;
        var component = CreateComponent<svanderweele.Core.Pieces.Tick.Components.TickDelayComponent>(index);
        component.delay = newDelay;
        ReplaceComponent(index, component);
    }

    public void RemoveTickDelay() {
        RemoveComponent(GameComponentsLookup.TickDelay);
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

    static Entitas.IMatcher<GameEntity> _matcherTickDelay;

    public static Entitas.IMatcher<GameEntity> TickDelay {
        get {
            if (_matcherTickDelay == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TickDelay);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTickDelay = matcher;
            }

            return _matcherTickDelay;
        }
    }
}
