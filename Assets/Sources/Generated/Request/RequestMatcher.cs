//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class RequestMatcher {

    public static Entitas.IAllOfMatcher<RequestEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<RequestEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<RequestEntity> AllOf(params Entitas.IMatcher<RequestEntity>[] matchers) {
          return Entitas.Matcher<RequestEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<RequestEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<RequestEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<RequestEntity> AnyOf(params Entitas.IMatcher<RequestEntity>[] matchers) {
          return Entitas.Matcher<RequestEntity>.AnyOf(matchers);
    }
}
