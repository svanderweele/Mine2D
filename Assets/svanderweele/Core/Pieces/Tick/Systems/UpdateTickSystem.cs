using Entitas;
using svanderweele.Core.Pieces.Tick.Services;
using svanderweele.Core.Pieces.Time;

namespace svanderweele.Core.Pieces.Tick.Systems
{
    public class UpdateTickSystem : IInitializeSystem, IExecuteSystem, ICleanupSystem
    {
        private readonly Contexts _contexts;
        private ITickService _tickService;
        private ITimeService _timeService;


        public UpdateTickSystem(Contexts contexts)
        {
            _contexts = contexts;
        }


        public void Initialize()
        {
            _timeService = _contexts.meta.timeService.time;
            _tickService = _contexts.meta.tickService.instance;
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
                        tick.delayValue -= _timeService.GetFixedDeltaTime();
                    }
                    else
                    {
                        if (tick.frozen)
                        {
                            continue;
                        }

                        tick.currentValue -= _timeService.GetFixedDeltaTime();

                        if (tick.currentValue <= 0)
                        {
                            //Reset tick value
                            var fps = _timeService.GetApplicationFrameRate();
                            var tickMultiplier = tick.multiplier;
                            var newTickValue = 1 / (tickMultiplier * fps);
                            tick.shouldTick = true;
                            _tickService.SetValue(gameEntity, ticksKey.Key, newTickValue);
                            _tickService.ResetDelay(gameEntity, ticksKey.Key);
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