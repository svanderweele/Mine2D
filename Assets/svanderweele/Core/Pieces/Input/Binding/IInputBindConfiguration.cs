using System.Collections.Generic;
using svanderweele.Mine.Game.Utils;

namespace svanderweele.Core.Pieces.Input.Binding
{
    public interface IInputBindConfiguration
    {
        List<InputBind> GetBinds(KeyId id);
        List<InputBind> GetBinds(string action);
        bool DoesBindExist(KeyId id, string action);
        void RemoveBinds(KeyId id);
        void RemoveBind(KeyId id, string action);
    }
}