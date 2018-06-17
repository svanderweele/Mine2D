public interface IInputService
{
    void Initialize(Contexts contexts);
    void SetHovered(int eid, bool hover);
    void SetPressed(int eid, bool press);

    bool IsHovered(int eid);
    bool IsPressed(int eid);
    bool IsHeldDown(int eid);
    bool IsHeldUp(int eid);
}