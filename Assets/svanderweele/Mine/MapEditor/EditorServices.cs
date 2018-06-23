using svanderweele.Core.Pieces.GridEditor.Service.Core;

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