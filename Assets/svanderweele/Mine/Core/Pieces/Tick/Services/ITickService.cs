namespace svanderweele.Mine.Core.Pieces.Tick.Services
{
    public interface ITickService
    {
        bool IsTick(ITickableEntity entity, TickEnum tickEnum);
        void SetFrozenState(ITickableEntity entity, TickEnum tickEnum, bool state);
        void SetValue(ITickableEntity entity, TickEnum tickEnum, float value);
        void SetDelay(ITickableEntity entity, TickEnum tickEnum, float delay);

        void ResetDelay(ITickableEntity entity, TickEnum tickEnum);
    }
}