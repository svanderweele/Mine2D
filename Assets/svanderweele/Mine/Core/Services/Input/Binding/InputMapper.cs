using System.Collections.Generic;
using System.Linq;
using svanderweele.Mine.Core.Services.Input.Service;
using UnityEngine;
using UnityEngine.Assertions;

namespace svanderweele.Mine.Core.Services.Input.Binding
{
    public abstract class InputMapper<T> : IInputMapper<T>
    {
        private Dictionary<KeyId, T> _mapTo;

        private Dictionary<T, KeyId> _mapFrom;


        public T ConvertTo(KeyId id)
        {
            Assert.IsTrue(_mapTo.ContainsKey(id), "Key Map not found " + id);
            return _mapTo[id];
        }

        public KeyId ConvertFrom(T id)
        {
            return _mapFrom[id];
        }

        public InputMapper()
        {
            _mapTo = new Dictionary<KeyId, T>();

            AddKeys();
            
            //Important to do this last
            _mapFrom = _mapFrom = _mapTo.ToDictionary(el => el.Value, el => el.Key);
        }

        protected abstract void AddKeys();

        protected void AddKeyMap(KeyId keyId, T keyCode)
        {
            _mapTo.Add(keyId, keyCode);
        }
    }
}