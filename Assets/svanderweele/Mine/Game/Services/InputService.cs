
using svanderweele.Mine.Core.Services.Input;
using System.Collections.Generic;

namespace svanderweele.Mine.Game.Services
{
    public class InputService : IInputService
    {
        private Dictionary<string, InputBind> _inputBinds;

        public InputService(Contexts contexts)
        {
            throw new System.NotImplementedException();
        }

        public void IsKeyDown(KeyMap map)
        {
            throw new System.NotImplementedException();
        }

        public void IsKeyPressed(KeyMap map)
        {
            throw new System.NotImplementedException();
        }

        public void IsKeyUp(KeyMap map)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveBind(string action)
        {
            throw new System.NotImplementedException();
        }

        public void SetBind(string action, KeyMap key)
        {
            throw new System.NotImplementedException();
        }

        public void SetHoverIn(int eid)
        {
            throw new System.NotImplementedException();
        }

        public void SetHoverOut(int eid)
        {
            throw new System.NotImplementedException();
        }

        public void SetPressDown(int eid)
        {
            throw new System.NotImplementedException();
        }

        public void SetPressUp(int eid)
        {
            throw new System.NotImplementedException();
        }
    }
}