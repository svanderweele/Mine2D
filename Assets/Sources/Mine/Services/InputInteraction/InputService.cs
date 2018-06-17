
using System;
using UnityEngine;

public class InputService : IInputService
{
    private Contexts _contexts;
    public void Initialize(Contexts contexts)
    {
        _contexts = contexts;
    }

    public bool IsHeld(int eid, HeldState state)
    {
        InputEntity entity = GetInputEntity(eid);
        return entity.interactionInput.InputData.HeldState == state;
    }

    public bool IsHover(int eid, HoverState state)
    {
        InputEntity entity = GetInputEntity(eid);
        return entity.interactionInput.InputData.HoverState == state;
    }

    public bool IsClicked(int eid)
    {
        InputEntity entity = GetInputEntity(eid);
        return entity.interactionInput.InputData.Clicked == true;
    }

    public void SetHovered(int eid, HoverState state)
    {
        var entity = GetOrCreateInputEntity(eid);
        entity.interactionInput.InputData.HoverState = state;
    }

    public void SetPressed(int eid, HeldState state)
    {
        var entity = GetOrCreateInputEntity(eid);

        var inputData = entity.interactionInput.InputData;
        float dt = Time.deltaTime;

        //Was 'clicked'?
        if (state == HeldState.Up)
        {
            if (inputData.HeldState == HeldState.Down)
            {
                var dtDifference = dt - inputData.PressTime;
                inputData.Clicked = dtDifference <= inputData.ClickThreshold;
            }
        }

        inputData.HeldState = state;
        inputData.PressTime = dt;
        entity.ReplaceInteractionInput(eid, inputData);
    }

    private InputEntity GetOrCreateInputEntity(int eid)
    {
        InputEntity entity = GetInputEntity(eid);

        if (entity != null)
        {
            return entity;
        }

        entity = _contexts.input.CreateEntity();
        float dt = Time.deltaTime;

        var inputData = new InputData()
        {
            ClickThreshold = 0.25f
        };

        entity.AddInteractionInput(eid, inputData);
        return entity;
    }

    private InputEntity GetInputEntity(int eid)
    {
        InputEntity entity = _contexts.input.GetEntityWithInteractionInput(eid);
        return entity;
    }

}