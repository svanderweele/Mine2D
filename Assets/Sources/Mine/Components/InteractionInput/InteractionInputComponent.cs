
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Input]
public class InteractionInputComponent : IComponent
{
    [PrimaryEntityIndex]
    public int eId;

    public InputData InputData;
    
}

public struct InputData
{
    public PressState PressState;
    public HoverState HoverState;
}


public enum PressState
{
    None = 0, 
    Down = 1,
    Up = 2
}

public enum HoverState
{
    None = 0,
    Over = 1,
    Out = 2
}
