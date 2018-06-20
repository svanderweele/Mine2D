using svanderweele.Mine.Game.Utils;

namespace svanderweele.Mine.Core.Services.Input.Service
{
    public interface IInputMapper<T>
    {
        T ConvertTo(KeyId id);
        KeyId ConvertFrom(T id);

    }
}