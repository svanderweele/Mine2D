using Entitas;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityGameView : MonoBehaviour, IViewController, IEventListener, IPositionListener, IVisibleListener
    {
        private GameEntity _entity;

        public void Link(Contexts contexts, IEntity entity)
        {
            _entity = (GameEntity) entity;
        }

        public void OnPosition(GameEntity entity, float x, float y)
        {
            transform.position = new Vector2(x, y);
        }

        public void RegisterEvents(Contexts contexts, IEntity entity)
        {
            _entity.AddPositionListener(this);
            _entity.AddVisibleListener(this);
        }

        public void OnVisible(GameEntity entity, bool isVisible)
        {
            gameObject.SetActive(isVisible);
        }
    }
}