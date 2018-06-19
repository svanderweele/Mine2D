
using svanderweele.Mine.Core.Services.Actions;
using svanderweele.Mine.Core.Services.Input;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Services
{
    public class CoreServices {

        public readonly IViewService View;
        public readonly IInputService Input;
        public readonly IActionService Action;
        
        public CoreServices(IViewService view, IInputService input, IActionService action){
            this.View = view;
            this.Input = input;
            this.Action = action;
        }
    }
}