using Boo.Lang;
using svanderweele.Mine.Core.Services.Input.Binding;
using svanderweele.Mine.Core.Services.Input.Controller;

namespace svanderweele.Mine.Core.Services.Input.Service
{
    public interface IInputService : IInputController, IInputBindConfiguration
    {
        bool IsKeyBindDown(string action);
        bool IsKeyBindUp(string action);
        bool IsKeyBindHeldDown(string action);

        //TODO : Toggle gameplay input binds (open_grid, pan camera etc)
        //TODO : Toggle cutscene input binds (skip_cutscene, pause etc)
    }

}