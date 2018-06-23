using svanderweele.Core.Pieces.Selection.Services;

namespace svanderweele.Core.Pieces
{
    public class CoreServiceCleanupSystems : Feature
    {
        public CoreServiceCleanupSystems(Contexts contexts)
        {
            Add(new SelectionCleanupSystem(contexts));
        }
    }
}