using svanderweele.Mine.Core.Pieces.GridEditor.Service;
using svanderweele.Mine.Core.Pieces.Tick.Services;
using svanderweele.Mine.Core.Pieces.Time;
using svanderweele.Mine.Core.Pieces.View;
using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;
using svanderweele.Mine.Core.Services.Selection;
using svanderweele.Mine.Core.Services.Time;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Pieces
{
    public class CoreServices
    {
        public readonly IViewService View;
        public readonly IInputService Input;
        public readonly IInputController InputController;
        public readonly ICollisionService Collision;
        public readonly ISelectionService Selection;
        public readonly ITimeService Time;
        public readonly ITickService Tick;
        
        public CoreServices(IViewService view, IInputService input, IInputController inputController, ICollisionService collision, ISelectionService selection, ITimeService time, ITickService tick)
        {
            View = view;
            Input = input;
            InputController = inputController;
            Collision = collision;
            Selection = selection;
            Time = time;
            Tick = tick;
        }

    }
}