using Entitas;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor
{
    [Command]
    public class CommandRequestCreateMapEditorComponent : IComponent
    {
        public int gridId;
    }
}