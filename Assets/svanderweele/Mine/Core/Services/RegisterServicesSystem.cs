using Entitas;
using svanderweele.Mine.Core.Services.Actions;
using svanderweele.Mine.Core.Services.Input;
using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Services
{
    public class RegisterServicesSystem : Feature
    {

        public RegisterServicesSystem(Contexts contexts, CoreServices services)
        {
            Add(new RegisterViewServiceSystem(contexts, services.View));
            Add(new RegisterInputServiceSystem(contexts, services.Input));
            Add(new RegisterInputControllerSystem(contexts, services.InputController));
        }

        public sealed override Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}