using System.Collections.Generic;

namespace svanderweele.Mine.Core.Services.Input.Binding
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