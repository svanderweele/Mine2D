﻿using svanderweele.Core.Pieces.Time;
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

        public float GetFixedDeltaTime()
        {
            return Time.fixedDeltaTime;
        }

        public int GetApplicationFrameRate()
        {
            return Application.targetFrameRate;
        }
    }
}