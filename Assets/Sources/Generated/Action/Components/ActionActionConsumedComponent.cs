//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity {

    static readonly svanderweele.Mine.Game.Actions.ActionConsumedComponent actionConsumedComponent = new svanderweele.Mine.Game.Actions.ActionConsumedComponent();

    public bool isActionConsumed {
        get { return HasComponent(ActionComponentsLookup.ActionConsumed); }
        set {
            if (value != isActionConsumed) {
                var index = ActionComponentsLookup.ActionConsumed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : actionConsumedComponent;

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
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ActionMatcher {

    static Entitas.IMatcher<ActionEntity> _matcherActionConsumed;

    public static Entitas.IMatcher<ActionEntity> ActionConsumed {
        get {
            if (_matcherActionConsumed == null) {
                var matcher = (Entitas.Matcher<ActionEntity>)Entitas.Matcher<ActionEntity>.AllOf(ActionComponentsLookup.ActionConsumed);
                matcher.componentNames = ActionComponentsLookup.componentNames;
                _matcherActionConsumed = matcher;
            }

            return _matcherActionConsumed;
        }
    }
}
