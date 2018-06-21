using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;
using svanderweele.Mine.Core.Services.Selection;
using svanderweele.Mine.Core.Services.Time;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Services
{
    public class CoreServices
    {
        public readonly IViewService View;
        public readonly IInputService Input;
        public readonly IInputController InputController;
        public readonly ICollisionService Collision;
        public readonly ISelectionService Selection;
        public readonly ITimeService Time;
        
        public CoreServices(IViewService view, IInputService input, IInputController inputController, ICollisionService collision, ISelectionService selection, ITimeService time)
        {
            this.View = view;
            this.Input = input;
            this.InputController = inputController;
            this.Collision = collision;
            this.Selection = selection;
            this.Time = time;
        }

    }
}