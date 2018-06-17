using System;
using Entitas;

public static class ContextsIdExtensions
{
    public static void SubscribeId (this Contexts contexts)
    {
        foreach (var context in contexts.allContexts)
        {
            if (Array.FindIndex(context.contextInfo.componentTypes, v => v == typeof(EIDComponent)) >= 0)
            {
                context.OnEntityCreated += AddId;
            }
        }
    }

    public static void AddId (IContext context, IEntity entity)
    {
        (entity as IEIDEntity).ReplaceEID(entity.creationIndex);
    }
}