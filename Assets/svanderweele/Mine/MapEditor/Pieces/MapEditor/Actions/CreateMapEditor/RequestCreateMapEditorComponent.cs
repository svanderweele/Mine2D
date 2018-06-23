using Entitas;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Actions.CreateMapEditor
{
    [Request]
    public class RequestCreateMapEditorComponent : IComponent
    {
        public int gridId;
    }
}