using svanderweele.Mine.GameEditor.Pieces.MapEditor.Actions.CreateMapEditor;
using svanderweele.Mine.GameEditor.Pieces.MapEditor.Systems;
using svanderweele.Mine.MapEditor.Pieces.MapEditor.Actions.CreateMapEditor;

namespace svanderweele.Mine.GameEditor
{
    public class EditorSystems : Feature
    {
        public EditorSystems(Contexts contexts)
        {
            Add(new RequestCreateMapEditorSystem(contexts));
            Add(new ActionCreateMapEditorSystem(contexts));
            Add(new UpdateAssetBayAssetsSystem(contexts));
        }
    }
}