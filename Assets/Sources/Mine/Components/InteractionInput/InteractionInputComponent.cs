
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Input]
public class InteractionInputComponent : IComponent
{
    [PrimaryEntityIndex]
    public int eId;

    public InputData InputData;

}

public class InputData
{
    public HeldState HeldState = HeldState.None;
    public HoverState HoverState = HoverState.None;

    public float PressTime = 0;
    public float HoverTime = 0;
    public float ClickThreshold = 0.25f; //25ms to register as click
    public bool Clicked = false;
}

