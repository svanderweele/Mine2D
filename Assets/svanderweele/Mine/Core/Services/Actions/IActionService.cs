
namespace svanderweele.Mine.Core.Services.Actions
{
    public interface IActionService
    {
        bool IsActionCalled(string action);
        void CallAction(string action, float delay = 0);
    }
}