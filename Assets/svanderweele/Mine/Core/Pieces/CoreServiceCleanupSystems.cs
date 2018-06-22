using svanderweele.Mine.Core.Services.Selection;

namespace svanderweele.Mine.Core.Services
{
    public class CoreServiceCleanupSystems : Feature
    {
        public CoreServiceCleanupSystems(Contexts contexts)
        {
            Add(new SelectionCleanupSystem(contexts));
        }
    }
}