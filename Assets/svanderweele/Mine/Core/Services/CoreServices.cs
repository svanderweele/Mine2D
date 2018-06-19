
using svanderweele.Mine.Core.Services.Actions;
using svanderweele.Mine.Core.Services.Input;
using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Services
{
    public class CoreServices {

        public readonly IViewService View;
        public readonly IInputService Input;
        //TODO : Remove Action Service
        public readonly IActionService Action;
        public readonly IInputController InputController;

        public CoreServices(IViewService view, IInputService input, IInputController inputController){
            this.View = view;
            this.Input = input;
            this.InputController = inputController;
        }

    }
}