using System;
using System.Collections.Generic;
using svanderweele.Mine.Core.Services.Input.Binding;
using svanderweele.Mine.Game.Utils;
using UnityEngine;
using UnityEngine.Profiling;

namespace svanderweele.Mine.Testing.InputBindTest
{
    public class InputBindConfiguration
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


        public static InputBindConfiguration Default()
        {
            var config = new InputBindConfiguration();
            config.AddBind(GlobalVariables.ACTION_EXIT_GAME, KeyId.Escape);
            return config;
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
    }


    public class InputBindConfigurationTest
    {
        private InputBindConfiguration _test;

        public InputBindConfigurationTest()
        {
            _test = new InputBindConfiguration();

            var actions = new string[]
            {
                GlobalVariables.ACTION_EXIT_GAME, GlobalVariables.ACTION_EXIT_GAME_01, GlobalVariables.ACTION_OPEN_GRID,
                GlobalVariables.ACTION_OPEN_GRID_02
            };

            foreach (var action in actions)
            {
                foreach (var value in Enum.GetValues(typeof(KeyId)))
                {
                    _test.AddBind(action, (KeyId) value);
                }
            }

            _test.RemoveBind(KeyId.A, GlobalVariables.ACTION_EXIT_GAME);
            Debug.Log("Remove Bind 'A' " + _test);

            _test.RemoveBinds(KeyId.D);
            Debug.Log("Remove Binds 'D' " + _test);

            Profiler.BeginSample("Get Binds");
            var binds = _test.GetBinds(GlobalVariables.ACTION_EXIT_GAME);
            Profiler.EndSample();

            var bindString = "";

            foreach (var inputBind in binds)
            {
                bindString += inputBind + "\n";
            }

            Debug.Log("ToString " + _test);
        }
    }
}