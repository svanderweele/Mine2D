using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;
using svanderweele.Mine.Core.Services.View;
using svanderweele.Mine.Game.Pieces.Grid.Service;

namespace svanderweele.Mine.Core.Services
{
    public class CoreServices
    {
        public readonly IViewService View;
        public readonly IInputService Input;
        public readonly IInputController InputController;
        public readonly IGridService Grid;
        public readonly ICollisionService Collision;

        public CoreServices(IViewService view, IInputService input, IInputController inputController, IGridService grid, ICollisionService collision)
        {
            this.View = view;
            this.Input = input;
            this.InputController = inputController;
            this.Grid = grid;
            this.Collision = collision;
        }

    }
}