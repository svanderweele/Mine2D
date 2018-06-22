namespace svanderweele.Mine.Core.Pieces.Tick.Services
{
    public interface ITickService
    {
        bool IsTick(ITickableEntity entity, TickEnum tickEnum);
    }
}