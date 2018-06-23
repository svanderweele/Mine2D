using Entitas;
using svanderweele.Core.Pieces.Collision.Services;
using svanderweele.Core.Pieces.Grid.Core.Service;
using svanderweele.Core.Pieces.GridEditor.Service.Core;
using svanderweele.Core.Pieces.Input.Controller;
using svanderweele.Core.Pieces.Input.Service;
using svanderweele.Core.Pieces.Selection.Services;
using svanderweele.Core.Pieces.Tick.Services;
using svanderweele.Core.Pieces.Time;
using svanderweele.Core.Pieces.View;
using svanderweele.Mine.Game;
using svanderweele.Mine.GameEditor;

namespace svanderweele.Core.Pieces
{
    public class RegisterServicesSystem : Feature
    {

        public RegisterServicesSystem(Contexts contexts, CoreServices coreServices, GameServices gameServices,
            EditorServices editorServices)
        {
            //Core Services
            Add(new RegisterTimeServiceSystem(contexts, coreServices.Time));
            Add(new RegisterCollisionServiceSystem(contexts, coreServices.Collision));
            Add(new RegisterViewServiceSystem(contexts, coreServices.View));
            Add(new RegisterInputServiceSystem(contexts, coreServices.Input));
            Add(new RegisterSelectionServiceSystem(contexts, coreServices.Selection));
            Add(new RegisterInputControllerSystem(contexts, coreServices.InputController));
            Add(new RegisterTickServiceSystem(contexts, coreServices.Tick));

            //Game Services
            Add(new RegisterGridServiceSystem(contexts, gameServices.Grid));
            
            //Editor Services
            Add(new RegisterGridEditorServiceSystem(contexts, editorServices.GridEditor));
        }

        public sealed override Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}