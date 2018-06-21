using svanderweele.Mine.Core.Services.Time;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityTimeService : ITimeService
    {
        public float GetTime()
        {
            return Time.time;
        }

        public float GetDeltaTime()
        {
            return Time.deltaTime;
        }
    }
}