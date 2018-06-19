using System.Collections.Generic;

namespace svanderweele.Mine.Core.Services.Input
{
    public interface IInputMapper<T>
    {
        Dictionary<KeyMap, T> MapTo { get; }
        Dictionary<T, KeyMap> MapFrom { get; }

        void InitializeKeys();
    }
}