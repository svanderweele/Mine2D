using System.Collections.Generic;
using svanderweele.Mine.Game.Utils;
using UnityEngine;

namespace svanderweele.Mine.Core.Services.Input.Binding
{
    public class InputBindConfiguration : IInputBindConfiguration
    {
        private readonly Dictionary<KeyId, List<InputBind>> _inputBinds;

        //Cache for quick querying
        private List<string> _bindedActions;

        public InputBindConfiguration()
        {
            _inputBinds = new Dictionary<KeyId, List<InputBind>>();
            _bindedActions = new List<string>();
        }

        public void AddBind(string action, KeyId id)
        {
            var binds = GetBinds(id);

            if (binds == null)
            {
                binds = new List<InputBind>();
            }


            if (DoesBindExist(id, action) == false)
            {
                var newBind = new InputBind(id, action);
                binds.Add(newBind);
                _bindedActions.Add(PrefixActionCache(id, action));
            }
            else
            {
                Debug.Log("Bind already exists " + action + " - " + id);
            }

            _inputBinds[id] = binds;
        }

        public void RemoveBind(KeyId id, string action)
        {
            var binds = GetBinds(id);
            if (binds == null)
            {
                return;
            }

            List<InputBind> toRemove = new List<InputBind>();

            foreach (var inputBind in binds)
            {
                if (inputBind.Action == action)
                {
                    toRemove.Add(inputBind);
                }
            }

            foreach (var inputBind in toRemove)
            {
                binds.Remove(inputBind);
                _bindedActions.Remove(PrefixActionCache(id, action));
            }
        }

        public void RemoveBinds(KeyId id)
        {
            var binds = GetBinds(id);

            if (binds == null)
            {
                return;
            }

            _inputBinds[id] = new List<InputBind>();
        }


        private string PrefixActionCache(KeyId id, string action)
        {
            return id + "-" + action;
        }

        public bool DoesBindExist(KeyId id, string action)
        {
            return _bindedActions.IndexOf(PrefixActionCache(id, action)) > -1;
            var binds = GetBinds(id);
            if (binds == null) return false;

            foreach (var inputBind in binds)
            {
                //Already exists
                return (inputBind.Action == action);
            }

            return false;
        }

        public List<InputBind> GetBinds(KeyId id)
        {
            if (_inputBinds.ContainsKey(id) == false)
            {
                return null;
            }

            return _inputBinds[id];
        }


        public List<InputBind> GetBinds(string action)
        {
            var binds = new List<InputBind>();

            foreach (var inputBind in _inputBinds)
            {
                foreach (var bind in inputBind.Value)
                {
                    if (bind.Action == action)
                    {
                        binds.Add(bind);
                    }
                }
            }

            return binds;
        }


        public override string ToString()
        {
            var s = "";
            foreach (var bind in _inputBinds)
            {
                //Key Binds
                var individualBinds = "";
                foreach (var inputBind in bind.Value)
                {
                    individualBinds += inputBind.Action + " ";
                }

                s += bind.Key + " > " + individualBinds + " \n";
            }

            return s;
        }


        public static InputBindConfiguration Default()
        {
            var config = new InputBindConfiguration();
            config.AddBind(GlobalVariables.ACTION_EXIT_GAME, KeyId.Escape);
            config.AddBind(GlobalVariables.ACTION_EXIT_GAME_01, KeyId.S);
            config.AddBind(GlobalVariables.ACTION_EXIT_GAME, KeyId.A);
            return config;
        }
    }
}