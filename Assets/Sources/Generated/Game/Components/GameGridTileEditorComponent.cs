//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Mine.Core.Pieces.Grid.GridEditor.Components.GridTileEditorComponent gridTileEditor { get { return (svanderweele.Mine.Core.Pieces.Grid.GridEditor.Components.GridTileEditorComponent)GetComponent(GameComponentsLookup.GridTileEditor); } }
    public bool hasGridTileEditor { get { return HasComponent(GameComponentsLookup.GridTileEditor); } }

    public void AddGridTileEditor(int newGridId) {
        var index = GameComponentsLookup.GridTileEditor;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.GridEditor.Components.GridTileEditorComponent>(index);
        component.gridId = newGridId;
        AddComponent(index, component);
    }

    public void ReplaceGridTileEditor(int newGridId) {
        var index = GameComponentsLookup.GridTileEditor;
        var component = CreateComponent<svanderweele.Mine.Core.Pieces.Grid.GridEditor.Components.GridTileEditorComponent>(index);
        component.gridId = newGridId;
        ReplaceComponent(index, component);
    }

    public void RemoveGridTileEditor() {
        RemoveComponent(GameComponentsLookup.GridTileEditor);
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

    static Entitas.IMatcher<GameEntity> _matcherGridTileEditor;

    public static Entitas.IMatcher<GameEntity> GridTileEditor {
        get {
            if (_matcherGridTileEditor == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GridTileEditor);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGridTileEditor = matcher;
            }

            return _matcherGridTileEditor;
        }
    }
}
