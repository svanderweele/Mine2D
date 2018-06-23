using svanderweele.Mine.Game.Utils;

namespace svanderweele.Core.Pieces.Input.Service
{
    public interface IInputMapper<T>
    {
        T ConvertTo(KeyId id);
        KeyId ConvertFrom(T id);

    }
}