//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IGridTileTypeEntity {

    svanderweele.Mine.Game.Pieces.Grid.Components.GridTileTypeComponent gridTileType { get; }
    bool hasGridTileType { get; }

    void AddGridTileType(string newType);
    void ReplaceGridTileType(string newType);
    void RemoveGridTileType();
}