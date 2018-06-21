using Entitas;
using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;
using svanderweele.Mine.Core.Services.Selection;
using svanderweele.Mine.Core.Services.Time;
using svanderweele.Mine.Core.Services.View;
using svanderweele.Mine.Game.Pieces.Grid.Service;
using svanderweele.Mine.Game.Services;

namespace svanderweele.Mine.Core.Services
{
    public class RegisterServicesSystem : Feature
    {

        public RegisterServicesSystem(Contexts contexts, CoreServices coreServices, GameServices gameServices)
        {
            Add(new RegisterTimeServiceSystem(contexts, coreServices.Time));
            Add(new RegisterGridServiceSystem(contexts, gameServices.Grid));
            Add(new RegisterCollisionServiceSystem(contexts, coreServices.Collision));
            Add(new RegisterViewServiceSystem(contexts, coreServices.View));
            Add(new RegisterInputServiceSystem(contexts, coreServices.Input));
            Add(new RegisterSelectionServiceSystem(contexts, coreServices.Selection));
            Add(new RegisterInputControllerSystem(contexts, coreServices.InputController));
        }

        public sealed override Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}