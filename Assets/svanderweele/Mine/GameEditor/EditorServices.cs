using svanderweele.Mine.Core.Pieces.GridEditor.Service;

namespace svanderweele.Mine.GameEditor
{
    public class EditorServices
    {
        public readonly IGridEditorService GridEditor;

        public EditorServices(IGridEditorService gridEditor)
        {
            GridEditor = gridEditor;
        }
    }
}