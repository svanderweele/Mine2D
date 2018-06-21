//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class CommandComponentsLookup {

    public const int CommandDestroyedListener = 0;
    public const int Command = 1;
    public const int CommandConsumed = 2;
    public const int CommandDelay = 3;
    public const int CommandRequest = 4;
    public const int HideEntityCommand = 5;
    public const int HideEntityRequest = 6;
    public const int Destroyed = 7;
    public const int CommandAddEntityToGrid = 8;
    public const int CommandRequestAddEntityToGrid = 9;
    public const int Id = 10;

    public const int TotalComponents = 11;

    public static readonly string[] componentNames = {
        "CommandDestroyedListener",
        "Command",
        "CommandConsumed",
        "CommandDelay",
        "CommandRequest",
        "HideEntityCommand",
        "HideEntityRequest",
        "Destroyed",
        "CommandAddEntityToGrid",
        "CommandRequestAddEntityToGrid",
        "Id"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(CommandDestroyedListenerComponent),
        typeof(svanderweele.Mine.Game.Commands.CommandComponent),
        typeof(svanderweele.Mine.Game.Commands.CommandConsumedComponent),
        typeof(svanderweele.Mine.Game.Commands.CommandDelayComponent),
        typeof(svanderweele.Mine.Game.Commands.CommandRequestComponent),
        typeof(svanderweele.Mine.Game.Commands.HideActor.HideEntityCommandComponent),
        typeof(svanderweele.Mine.Game.Commands.Requests.HideActor.HideEntityRequestComponent),
        typeof(svanderweele.Mine.Game.Pieces.Destroy.DestroyedComponent),
        typeof(svanderweele.Mine.Game.Pieces.Grid.Commands.CommandAddEntityToGridComponent),
        typeof(svanderweele.Mine.Game.Pieces.Grid.Commands.CommandRequestAddEntityToGridComponent),
        typeof(svanderweele.Mine.Game.Pieces.Id.IdComponent)
    };
}
