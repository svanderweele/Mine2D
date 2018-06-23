using Entitas;
using svanderweele.Core.Pieces.GridEditor.Interfaces;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Components
{
    [MapEditor]
    public class MapEditorComponent : IComponent
    {
        public IGridEditorView view;
    }
}