//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CommandEntity {

    static readonly svanderweele.Mine.Game.Commands.CommandComponent commandComponent = new svanderweele.Mine.Game.Commands.CommandComponent();

    public bool isCommand {
        get { return HasComponent(CommandComponentsLookup.Command); }
        set {
            if (value != isCommand) {
                var index = CommandComponentsLookup.Command;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : commandComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<CommandEntity> _matcherCommand;

    public static Entitas.IMatcher<CommandEntity> Command {
        get {
            if (_matcherCommand == null) {
                var matcher = (Entitas.Matcher<CommandEntity>)Entitas.Matcher<CommandEntity>.AllOf(CommandComponentsLookup.Command);
                matcher.componentNames = CommandComponentsLookup.componentNames;
                _matcherCommand = matcher;
            }

            return _matcherCommand;
        }
    }
}
