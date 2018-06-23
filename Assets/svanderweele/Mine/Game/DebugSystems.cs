using svanderweele.Core.Pieces.Selection.Systems;

namespace svanderweele.Mine.Game
{
    public class DebugSystems : Feature
    {
        public DebugSystems(Contexts contexts)
        {
            Add(new DebugSelectionSystem(contexts));
        }
    }
}