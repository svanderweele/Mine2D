using Entitas;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor
{
    [Command]
    public class CommandCreateMapEditorComponent : IComponent
    {
        public int gridId;
    }
}