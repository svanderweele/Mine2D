namespace svanderweele.Mine.Core.Pieces.Time
{
    public interface ITimeService
    {
        float GetTime();
        float GetDeltaTime();
        float GetFixedDeltaTime();

        //TODO : Should I create an Application service for this?
        int GetApplicationFrameRate();
    }
}