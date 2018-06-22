//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GridEntity {

    public svanderweele.Mine.Core.Pieces.Grid.Core.Components.GridTileSizeComponent gridTileSize { get { return (svanderweele.Mine.Core.Pieces.Grid.Core.Components.GridTileSizeComponent)GetComponent(GridComponentsLookup.GridTileSize); } }
    public bool hasGridTileSize { get { return HasComponent(GridComponentsLookup.GridTileSize); } }

    public void AddGridTileSize(float newTileWidth, float newTileHeight) {
        var index = GridComponentsLookup.GridTileSize;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.Core.Components.GridTileSizeComponent>(index);
        component.tileWidth = newTileWidth;
        component.tileHeight = newTileHeight;
        AddComponent(index, component);
    }

    public void ReplaceGridTileSize(float newTileWidth, float newTileHeight) {
        var index = GridComponentsLookup.GridTileSize;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.Core.Components.GridTileSizeComponent>(index);
        component.tileWidth = newTileWidth;
        component.tileHeight = newTileHeight;
        ReplaceComponent(index, component);
    }

    public void RemoveGridTileSize() {
        RemoveComponent(GridComponentsLookup.GridTileSize);
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

    static Entitas.IMatcher<GridEntity> _matcherGridTileSize;

    public static Entitas.IMatcher<GridEntity> GridTileSize {
        get {
            if (_matcherGridTileSize == null) {
                var matcher = (Entitas.Matcher<GridEntity>)Entitas.Matcher<GridEntity>.AllOf(GridComponentsLookup.GridTileSize);
                matcher.componentNames = GridComponentsLookup.componentNames;
                _matcherGridTileSize = matcher;
            }

            return _matcherGridTileSize;
        }
    }
}
