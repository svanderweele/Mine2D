using System.Runtime.InteropServices;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.Core.Pieces.Tick.Systems
{
    public class UpdateTickSystem : IExecuteSystem, ICleanupSystem
    {
        private readonly Contexts _contexts;


        public UpdateTickSystem(Contexts contexts)
        {
            _contexts = contexts;
        }


        public void Execute()
        {
            var tickEntities = _contexts.game.GetEntities(GameMatcher.Tick);

            foreach (var gameEntity in tickEntities)
            {
                var ticks = gameEntity.tick.ticks;
                foreach (var ticksKey in ticks)
                {
                    var tick = ticks[ticksKey.Key];

                    if (tick.delayValue > 0)
                    {
                        tick.delayValue -= Time.fixedDeltaTime;
                    }
                    else
                    {
                        tick.currentValue -= Time.fixedDeltaTime;

                        if (tick.currentValue <= 0)
                        {
                            //Reset tick value
                            //TODO : Create service for frame rate 
                            var fps = Application.targetFrameRate;
                            var tickMultiplier = tick.multiplier;
                            var newTickValue = 1 / (tickMultiplier * fps);
                            tick.value = newTickValue;
                            tick.currentValue = newTickValue;
                            tick.shouldTick = true;

                            tick.delayValue = tick.delay;
                        }
                    }
                }

                gameEntity.ReplaceTick(ticks);
            }
        }

        public void Cleanup()
        {
            var tickEntities = _contexts.game.GetEntities(GameMatcher.Tick);
            foreach (var tickEntity in tickEntities)
            {
                var ticks = tickEntity.tick.ticks;
                foreach (var ticksKey in ticks)
                {
                    var tick = ticks[ticksKey.Key];
                    if (tick.shouldTick)
                    {
                        tick.shouldTick = false;
                    }

                    tickEntity.ReplaceTick(ticks);
                }
            }
        }
    }
}