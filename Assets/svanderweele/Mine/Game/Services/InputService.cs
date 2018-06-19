using svanderweele.Mine.Core.Services.Input.Binding;
using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;

namespace svanderweele.Mine.Game.Services
{
    public class InputService : IInputService
    {
        private InputBindConfiguration _bindConfig;
        private MetaContext _metaContext;
        private IInputController _inputController
        {
            get { return _metaContext.inputController.instance; }
        }

        public InputService(Contexts contexts)
        {
            _metaContext = contexts.meta;
            _bindConfig = InputBindConfiguration.Default();
        }

        private IInputController GetInputController()
        {
            return _metaContext.inputController.instance;
        }

        public bool IsKeyBindDown(string action)
        {
            var binds = _bindConfig.GetBinds(action);


            foreach (var bind in binds)
            {
                if (IsKeyDown(bind.Key))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsKeyBindUp(string action)
        {
            var binds = _bindConfig.GetBinds(action);


            foreach (var bind in binds)
            {
                if (IsKeyUp(bind.Key))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsKeyBindHeldDown(string action)
        {
            var binds = _bindConfig.GetBinds(action);


            foreach (var bind in binds)
            {
                if (IsKeyHeldDown(bind.Key))
                {
                    return true;
                }
            }

            return false;
        }


        public bool IsKeyHeldDown(KeyId id)
        {
            return _inputController.IsKeyHeldDown(id);
        }

        public bool IsKeyDown(KeyId id)
        {
            return _inputController.IsKeyDown(id);
        }

        public bool IsKeyUp(KeyId id)
        {
            return _inputController.IsKeyUp(id);
        }

        public bool IsMouseUp()
        {
            return _inputController.IsMouseUp();
        }

        public bool IsMouseDown()
        {
            return _inputController.IsMouseDown();
        }

        public System.Collections.Generic.List<InputBind> GetBinds(KeyId id)
        {
            return _bindConfig.GetBinds(id);
        }

        public System.Collections.Generic.List<InputBind> GetBinds(string action)
        {
            return _bindConfig.GetBinds(action);
        }

        public bool DoesBindExist(KeyId id, string action)
        {
            return _bindConfig.DoesBindExist(id, action);
        }

        public void RemoveBinds(KeyId id)
        {
            _bindConfig.RemoveBinds(id);
        }

        public void RemoveBind(KeyId id, string action)
        {
            _bindConfig.RemoveBind(id, action);
        }
    }
}