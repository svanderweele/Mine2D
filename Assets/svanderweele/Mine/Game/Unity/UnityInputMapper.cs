using System.Collections.Generic;
using System.Linq;
using svanderweele.Mine.Core.Services.Input;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityInputMapper : IInputMapper<KeyCode>
    {
        public Dictionary<KeyMap, KeyCode> MapTo
        {
            get { return _mapTo; }
        }
    
        public Dictionary<KeyCode, KeyMap> MapFrom
        {
            get { return _mapFrom; }
        }

        private Dictionary<KeyMap, KeyCode> _mapTo;

        private Dictionary<KeyCode, KeyMap> _mapFrom;


        public void InitializeKeys()
        {
            _mapTo = new Dictionary<KeyMap, KeyCode>()
            {
                {KeyMap.W, KeyCode.W},
                {KeyMap.A, KeyCode.A},
                {KeyMap.S, KeyCode.S},
                {KeyMap.D, KeyCode.D},
            };
        
            _mapFrom = _mapFrom = _mapTo.ToDictionary(el => el.Value, el => el.Key);
        }
    }
}