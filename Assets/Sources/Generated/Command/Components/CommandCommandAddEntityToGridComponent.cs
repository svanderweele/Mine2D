//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CommandEntity {

    public svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandAddEntityToGridComponent commandAddEntityToGrid { get { return (svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandAddEntityToGridComponent)GetComponent(CommandComponentsLookup.CommandAddEntityToGrid); } }
    public bool hasCommandAddEntityToGrid { get { return HasComponent(CommandComponentsLookup.CommandAddEntityToGrid); } }

    public void AddCommandAddEntityToGrid(int newEntityId, int newGridId, int newLayer) {
        var index = CommandComponentsLookup.CommandAddEntityToGrid;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandAddEntityToGridComponent>(index);
        component.entityId = newEntityId;
        component.gridId = newGridId;
        component.layer = newLayer;
        AddComponent(index, component);
    }

    public void ReplaceCommandAddEntityToGrid(int newEntityId, int newGridId, int newLayer) {
        var index = CommandComponentsLookup.CommandAddEntityToGrid;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.Core.Commands.AddEntityToGrid.CommandAddEntityToGridComponent>(index);
        component.entityId = newEntityId;
        component.gridId = newGridId;
        component.layer = newLayer;
        ReplaceComponent(index, component);
    }

    public void RemoveCommandAddEntityToGrid() {
        RemoveComponent(CommandComponentsLookup.CommandAddEntityToGrid);
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

    static Entitas.IMatcher<CommandEntity> _matcherCommandAddEntityToGrid;

    public static Entitas.IMatcher<CommandEntity> CommandAddEntityToGrid {
        get {
            if (_matcherCommandAddEntityToGrid == null) {
                var matcher = (Entitas.Matcher<CommandEntity>)Entitas.Matcher<CommandEntity>.AllOf(CommandComponentsLookup.CommandAddEntityToGrid);
                matcher.componentNames = CommandComponentsLookup.componentNames;
                _matcherCommandAddEntityToGrid = matcher;
            }

            return _matcherCommandAddEntityToGrid;
        }
    }
}
