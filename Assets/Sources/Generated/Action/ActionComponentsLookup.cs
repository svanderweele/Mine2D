//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class ActionComponentsLookup {

    public const int ActionDestroyedListener = 0;
    public const int Action = 1;
    public const int ActionConsumed = 2;
    public const int HideEntityAction = 3;
    public const int Destroyed = 4;
    public const int Id = 5;

    public const int TotalComponents = 6;

    public static readonly string[] componentNames = {
        "ActionDestroyedListener",
        "Action",
        "ActionConsumed",
        "HideEntityAction",
        "Destroyed",
        "Id"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(ActionDestroyedListenerComponent),
        typeof(svanderweele.Mine.Game.Actions.ActionComponent),
        typeof(svanderweele.Mine.Game.Actions.ActionConsumedComponent),
        typeof(svanderweele.Mine.Game.Actions.HideEntityActionComponent),
        typeof(svanderweele.Mine.Game.Components.Destroy.DestroyedComponent),
        typeof(svanderweele.Mine.Game.Components.Id.IdComponent)
    };
}