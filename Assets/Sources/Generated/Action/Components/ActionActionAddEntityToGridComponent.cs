//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity {

    public svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid.ActionAddEntityToGridComponent actionAddEntityToGrid { get { return (svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid.ActionAddEntityToGridComponent)GetComponent(ActionComponentsLookup.ActionAddEntityToGrid); } }
    public bool hasActionAddEntityToGrid { get { return HasComponent(ActionComponentsLookup.ActionAddEntityToGrid); } }

    public void AddActionAddEntityToGrid(int newEntityId, int newGridId, int newLayer) {
        var index = ActionComponentsLookup.ActionAddEntityToGrid;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid.ActionAddEntityToGridComponent>(index);
        component.entityId = newEntityId;
        component.gridId = newGridId;
        component.layer = newLayer;
        AddComponent(index, component);
    }

    public void ReplaceActionAddEntityToGrid(int newEntityId, int newGridId, int newLayer) {
        var index = ActionComponentsLookup.ActionAddEntityToGrid;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid.ActionAddEntityToGridComponent>(index);
        component.entityId = newEntityId;
        component.gridId = newGridId;
        component.layer = newLayer;
        ReplaceComponent(index, component);
    }

    public void RemoveActionAddEntityToGrid() {
        RemoveComponent(ActionComponentsLookup.ActionAddEntityToGrid);
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

    static Entitas.IMatcher<ActionEntity> _matcherActionAddEntityToGrid;

    public static Entitas.IMatcher<ActionEntity> ActionAddEntityToGrid {
        get {
            if (_matcherActionAddEntityToGrid == null) {
                var matcher = (Entitas.Matcher<ActionEntity>)Entitas.Matcher<ActionEntity>.AllOf(ActionComponentsLookup.ActionAddEntityToGrid);
                matcher.componentNames = ActionComponentsLookup.componentNames;
                _matcherActionAddEntityToGrid = matcher;
            }

            return _matcherActionAddEntityToGrid;
        }
    }
}
