//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class MetaComponentsLookup {

    public const int CollisionService = 0;
    public const int InputController = 1;
    public const int InputService = 2;
    public const int ViewService = 3;
    public const int GridService = 4;
    public const int Id = 5;

    public const int TotalComponents = 6;

    public static readonly string[] componentNames = {
        "CollisionService",
        "InputController",
        "InputService",
        "ViewService",
        "GridService",
        "Id"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(svanderweele.Mine.Core.Services.Collision.CollisionServiceComponent),
        typeof(svanderweele.Mine.Core.Services.Input.Controller.InputControllerComponent),
        typeof(svanderweele.Mine.Core.Services.Input.Service.InputServiceComponent),
        typeof(svanderweele.Mine.Core.Services.View.ViewServiceComponent),
        typeof(svanderweele.Mine.Game.Pieces.Grid.Service.GridServiceComponent),
        typeof(svanderweele.Mine.Game.Pieces.Id.IdComponent)
    };
}
