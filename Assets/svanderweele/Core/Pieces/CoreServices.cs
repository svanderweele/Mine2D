using svanderweele.Core.Pieces.Collision.Services;
using svanderweele.Core.Pieces.Input.Controller;
using svanderweele.Core.Pieces.Input.Service;
using svanderweele.Core.Pieces.Selection.Services;
using svanderweele.Core.Pieces.Tick.Services;
using svanderweele.Core.Pieces.Time;
using svanderweele.Core.Pieces.View;

namespace svanderweele.Core.Pieces
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