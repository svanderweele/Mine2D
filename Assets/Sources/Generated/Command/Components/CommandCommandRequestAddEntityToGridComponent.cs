//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CommandEntity {

    public svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandRequestAddEntityToGridComponent commandRequestAddEntityToGrid { get { return (svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandRequestAddEntityToGridComponent)GetComponent(CommandComponentsLookup.CommandRequestAddEntityToGrid); } }
    public bool hasCommandRequestAddEntityToGrid { get { return HasComponent(CommandComponentsLookup.CommandRequestAddEntityToGrid); } }

    public void AddCommandRequestAddEntityToGrid(int newEntityId, int newGridId, int newLayer) {
        var index = CommandComponentsLookup.CommandRequestAddEntityToGrid;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandRequestAddEntityToGridComponent>(index);
        component.entityId = newEntityId;
        component.gridId = newGridId;
        component.layer = newLayer;
        AddComponent(index, component);
    }

    public void ReplaceCommandRequestAddEntityToGrid(int newEntityId, int newGridId, int newLayer) {
        var index = CommandComponentsLookup.CommandRequestAddEntityToGrid;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandRequestAddEntityToGridComponent>(index);
        component.entityId = newEntityId;
        component.gridId = newGridId;
        component.layer = newLayer;
        ReplaceComponent(index, component);
    }

    public void RemoveCommandRequestAddEntityToGrid() {
        RemoveComponent(CommandComponentsLookup.CommandRequestAddEntityToGrid);
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
public sealed partial class CommandMatcher {

    static Entitas.IMatcher<CommandEntity> _matcherCommandRequestAddEntityToGrid;

    public static Entitas.IMatcher<CommandEntity> CommandRequestAddEntityToGrid {
        get {
            if (_matcherCommandRequestAddEntityToGrid == null) {
                var matcher = (Entitas.Matcher<CommandEntity>)Entitas.Matcher<CommandEntity>.AllOf(CommandComponentsLookup.CommandRequestAddEntityToGrid);
                matcher.componentNames = CommandComponentsLookup.componentNames;
                _matcherCommandRequestAddEntityToGrid = matcher;
            }

            return _matcherCommandRequestAddEntityToGrid;
        }
    }
}
