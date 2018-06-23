//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Core.Pieces.Grid.Core.Components.GridPositionComponent gridPosition { get { return (svanderweele.Core.Pieces.Grid.Core.Components.GridPositionComponent)GetComponent(GameComponentsLookup.GridPosition); } }
    public bool hasGridPosition { get { return HasComponent(GameComponentsLookup.GridPosition); } }

    public void AddGridPosition(svanderweele.Mine.Game.Utils.Math.Vector2 newPosition) {
        var index = GameComponentsLookup.GridPosition;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridPositionComponent>(index);
        component.position = newPosition;
        AddComponent(index, component);
    }

    public void ReplaceGridPosition(svanderweele.Mine.Game.Utils.Math.Vector2 newPosition) {
        var index = GameComponentsLookup.GridPosition;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridPositionComponent>(index);
        component.position = newPosition;
        ReplaceComponent(index, component);
    }

    public void RemoveGridPosition() {
        RemoveComponent(GameComponentsLookup.GridPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherGridPosition;

    public static Entitas.IMatcher<GameEntity> GridPosition {
        get {
            if (_matcherGridPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GridPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGridPosition = matcher;
            }

            return _matcherGridPosition;
        }
    }
}
