//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class CommandMatcher {

    public static Entitas.IAllOfMatcher<CommandEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<CommandEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<CommandEntity> AllOf(params Entitas.IMatcher<CommandEntity>[] matchers) {
          return Entitas.Matcher<CommandEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<CommandEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<CommandEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<CommandEntity> AnyOf(params Entitas.IMatcher<CommandEntity>[] matchers) {
          return Entitas.Matcher<CommandEntity>.AnyOf(matchers);
    }
}
