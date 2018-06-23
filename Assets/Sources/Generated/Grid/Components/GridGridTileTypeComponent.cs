//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GridEntity {

    public svanderweele.Core.Pieces.Grid.Core.Components.GridTileTypeComponent gridTileType { get { return (svanderweele.Core.Pieces.Grid.Core.Components.GridTileTypeComponent)GetComponent(GridComponentsLookup.GridTileType); } }
    public bool hasGridTileType { get { return HasComponent(GridComponentsLookup.GridTileType); } }

    public void AddGridTileType(string newType) {
        var index = GridComponentsLookup.GridTileType;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridTileTypeComponent>(index);
        component.type = newType;
        AddComponent(index, component);
    }

    public void ReplaceGridTileType(string newType) {
        var index = GridComponentsLookup.GridTileType;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridTileTypeComponent>(index);
        component.type = newType;
        ReplaceComponent(index, component);
    }

    public void RemoveGridTileType() {
        RemoveComponent(GridComponentsLookup.GridTileType);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GridEntity : IGridTileTypeEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GridMatcher {

    static Entitas.IMatcher<GridEntity> _matcherGridTileType;

    public static Entitas.IMatcher<GridEntity> GridTileType {
        get {
            if (_matcherGridTileType == null) {
                var matcher = (Entitas.Matcher<GridEntity>)Entitas.Matcher<GridEntity>.AllOf(GridComponentsLookup.GridTileType);
                matcher.componentNames = GridComponentsLookup.componentNames;
                _matcherGridTileType = matcher;
            }

            return _matcherGridTileType;
        }
    }
}
