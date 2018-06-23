using Entitas;
using svanderweele.Core.Pieces.Events.Interfaces;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity.Position
{
    public class UnityPositionController : MonoBehaviour, IEventListener, IPositionListener
    {
        public void RegisterEvents(Contexts contexts, IEntity entity)
        {
            ((GameEntity) entity).AddPositionListener(this);
        }

        public void OnPosition(GameEntity entity, float x, float y)
        {
            transform.position = new Vector2(x, y);
        }
    }
}