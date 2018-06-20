using svanderweele.Mine.Core.Services.Input.Controller;
using svanderweele.Mine.Core.Services.Input.Service;
using svanderweele.Mine.Game.Utils;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityInputController : IInputController
    {
        private IInputMapper<KeyCode> _inputMapper;

        public UnityInputController(IInputMapper<KeyCode> controller)
        {
            _inputMapper = controller;
        }

        public bool IsKeyHeldDown(KeyId id)
        {
            return Input.GetKey(_inputMapper.ConvertTo(id));
        }

        public bool IsKeyDown(KeyId id)
        {
            return Input.GetKeyDown(_inputMapper.ConvertTo(id));
        }

        public bool IsKeyUp(KeyId id)
        {
            return Input.GetKeyUp(_inputMapper.ConvertTo(id));
        }

        public bool IsMouseUp()
        {
            return Input.GetMouseButtonUp(0);
        }

        public bool IsMouseDown()
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}