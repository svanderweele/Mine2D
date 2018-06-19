
using svanderweele.Mine.Core.Services.Actions;

namespace svanderweele.Mine.Game.Services.Actions
{
    public class ActionService : IActionService
    {
        private ActionContext _actionContext;
        public ActionService(Contexts contexts)
        {
            _actionContext = contexts.action;
        }

        public void CallAction(string action, float delay = 0)
        {
            var e = _actionContext.CreateEntity();
            e.AddAction(action, delay);
        }

        public bool IsActionCalled(string action)
        {
            var entities = _actionContext.GetEntitiesWithAction(action);
            return entities.Count > 0;
        }
    }
}