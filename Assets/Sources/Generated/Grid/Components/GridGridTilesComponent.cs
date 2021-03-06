//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GridEntity {

    public svanderweele.Core.Pieces.Grid.Core.Components.GridTilesComponent gridTiles { get { return (svanderweele.Core.Pieces.Grid.Core.Components.GridTilesComponent)GetComponent(GridComponentsLookup.GridTiles); } }
    public bool hasGridTiles { get { return HasComponent(GridComponentsLookup.GridTiles); } }

    public void AddGridTiles(svanderweele.Core.Pieces.Grid.Core.Components.TileEntities[,] newTiles) {
        var index = GridComponentsLookup.GridTiles;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridTilesComponent>(index);
        component.tiles = newTiles;
        AddComponent(index, component);
    }

    public void ReplaceGridTiles(svanderweele.Core.Pieces.Grid.Core.Components.TileEntities[,] newTiles) {
        var index = GridComponentsLookup.GridTiles;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridTilesComponent>(index);
        component.tiles = newTiles;
        ReplaceComponent(index, component);
    }

    public void RemoveGridTiles() {
        RemoveComponent(GridComponentsLookup.GridTiles);
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
public sealed partial class GridMatcher {

    static Entitas.IMatcher<GridEntity> _matcherGridTiles;

    public static Entitas.IMatcher<GridEntity> GridTiles {
        get {
            if (_matcherGridTiles == null) {
                var matcher = (Entitas.Matcher<GridEntity>)Entitas.Matcher<GridEntity>.AllOf(GridComponentsLookup.GridTiles);
                matcher.componentNames = GridComponentsLookup.componentNames;
                _matcherGridTiles = matcher;
            }

            return _matcherGridTiles;
        }
    }
}
