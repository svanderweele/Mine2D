namespace svanderweele.Core.Pieces.Selection.Services
{
    public interface ISelectionService
    {
        bool IsHoverOver(int entityId);
        bool IsHoverOut(int entityId);
        bool IsHoverSelect(int entityId);

        bool IsSelectionDown(int entityId);
        bool IsSelectionUp(int entityId);
        bool IsSelectionHeld(int entityId);

        void SetSelectionDown(int entityId);
        void SetSelectionUp(int entityId);
        void SetSelectionOver(int entityId);
        void SetSelectionOut(int entityId);

    }
}