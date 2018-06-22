using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.Core.Pieces.Tick.Systems
{
    public class TestTickSystem : ReactiveSystem<GameEntity>
    {
        public TestTickSystem(Contexts contexts) : base(contexts.game)
        {
            _times = new List<float>();
        }

        private int runTime = 30;
        private int test = 61;
        private float _startTime = 0;

        private List<float> _times;

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.AnyOf(GameMatcher.Tick));
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasTick;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var gameEntity in entities)
            {
                //Should tick

                if (gameEntity.tick.ticks[TickEnum.MapEditor_AssetLoading].shouldTick == false)
                {
                    continue;
                }
                Debug.Log("Tick");

                test--;

                if (test == 60)
                {
                    _startTime = Time.time;
                }
                else if (test == 0)
                {
                    float timeDifference = Time.time - _startTime;
                    runTime--;
                    if (runTime > 0)
                    {
                        Debug.Log("Ended Test #" + (30 - runTime) + " - " + timeDifference);
                        test = 61;
                    }
                    else
                    {
                        Debug.Log("Average Time: " + _times.Average());
                    }
                }
            }
        }
    }
}