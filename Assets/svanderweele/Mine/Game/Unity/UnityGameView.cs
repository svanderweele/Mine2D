using Entitas;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityGameView : MonoBehaviour, IViewController, IEventListener, IPositionListener, IVisibleListener,
        ISpriteListener
    {
        private Contexts _contexts;
        private GameEntity _entity;
        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public Utils.Math.Vector2 GetPosition()
        {
            var vec = new Utils.Math.Vector2() {x = transform.position.x, y = transform.position.y};
            return vec;
        }

        public void Link(Contexts contexts, IEntity entity)
        {
            _entity = (GameEntity) entity;
        }

        public int GetEntityId()
        {
            return _entity.id.value;
        }

        public void OnPosition(GameEntity entity, float x, float y)
        {
            transform.position = new Vector2(x, y);
        }

        public void RegisterEvents(Contexts contexts, IEntity entity)
        {
            _entity.AddPositionListener(this);
            _entity.AddVisibleListener(this);
            _entity.AddSpriteListener(this);
        }

        public void OnVisible(GameEntity entity, bool isVisible)
        {
            gameObject.SetActive(isVisible);
        }

        public void OnSprite(GameEntity entity, string name)
        {
            if (_spriteRenderer.sprite == null || _spriteRenderer.sprite.name != name)
            {
                _spriteRenderer.sprite = Resources.Load<Sprite>(name);
            }
        }
    }
}