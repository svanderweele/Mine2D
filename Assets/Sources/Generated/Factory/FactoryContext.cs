//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class FactoryContext : Entitas.Context<FactoryEntity> {

    public FactoryContext()
        : base(
            FactoryComponentsLookup.TotalComponents,
            0,
            new Entitas.ContextInfo(
                "Factory",
                FactoryComponentsLookup.componentNames,
                FactoryComponentsLookup.componentTypes
            ),
            (entity) =>

#if (ENTITAS_FAST_AND_UNSAFE)
                new Entitas.UnsafeAERC()
#else
                new Entitas.SafeAERC(entity)
#endif

        ) {
    }
}