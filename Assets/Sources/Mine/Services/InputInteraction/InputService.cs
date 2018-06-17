
using System;

public class InputService : IInputService
{
    private Contexts _contexts;
    public void Initialize(Contexts contexts)
    {
        _contexts = contexts;
    }

    public bool IsHeldDown(int eid)
    {
        InputEntity entity = GetEntityWithEID(eid);
        bool heldDown = false;


        return heldDown;
    }

    public bool IsHeldUp(int eid)
    {
        throw new System.NotImplementedException();
    }

    public bool IsHovered(int eid)
    {
        throw new System.NotImplementedException();
    }

    public bool IsPressed(int eid)
    {
        throw new System.NotImplementedException();
    }

    public void SetHovered(int eid, bool hover)
    {
        throw new System.NotImplementedException();
    }

    public void SetPressed(int eid, bool press)
    {
        var entity = GetOrCreateInputEntity(eid);
    }

    private InputEntity GetOrCreateInputEntity(int eid)
    {
        InputEntity entity = _contexts.input.GetEntityWithInteractionInput(eid);

        if (entity != null)
        {
            return entity;
        }

        entity = _contexts.input.CreateEntity();
        return entity;
    }

    private InputEntity GetEntityWithEID(int eid)
    {
        return _contexts.input.GetEntityWithInteractionInput(eid);
    }
}