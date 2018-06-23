using svanderweele.Mine.GameEditor.Pieces.MapEditor.Action.CreateMapEditor;
using svanderweele.Mine.GameEditor.Pieces.MapEditor.Actions.CreateMapEditor;
using svanderweele.Mine.GameEditor.Pieces.MapEditor.Systems;

namespace svanderweele.Mine.GameEditor
{
    public class EditorSystems : Feature
    {
        public EditorSystems(Contexts contexts)
        {
            Add(new RequestCreateMapEditorSystem(contexts));
            Add(new CreateMapEditorSystem(contexts));
            Add(new UpdateAssetBayAssetsSystem(contexts));
        }
    }
}