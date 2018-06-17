public interface IInputService
{
    void Initialize(Contexts contexts);

    void SetHovered(int eid, HoverState state);
    void SetPressed(int eid, HeldState state);

    bool IsHover(int eid, HoverState state);
    bool IsHeld(int eid, HeldState state);
    bool IsClicked(int eid);
}


public enum HeldState
{
    None = 0,
    Down = 1,
    Up = 2,
}

public enum HoverState
{
    None = 0,
    Over = 1,
    Out = 2
}
