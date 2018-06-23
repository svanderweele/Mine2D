using Entitas;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Action.CreateMapEditor
{
    [Action]
    public class RequestCreateMapEditorComponent : IComponent
    {
        public int gridId;
    }
}