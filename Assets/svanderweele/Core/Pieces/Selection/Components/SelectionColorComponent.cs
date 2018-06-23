using Entitas;
using svanderweele.Mine.Game.Utils.Containers;

namespace svanderweele.Core.Pieces.Selection.Components
{
    [Game]
    public class SelectionColorComponent : IComponent
    {
        public Color selectionDown;
        public Color selectionUp;
        public Color selectionHeld;
        public Color selectionHoverOut;
        public Color selectionHoverIn;
        public Color selectionHoverSelect;
    }
}