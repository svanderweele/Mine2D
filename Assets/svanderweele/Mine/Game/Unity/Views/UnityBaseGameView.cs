using Entitas;
using svanderweele.Core.Pieces.Collision.Services;
using svanderweele.Core.Pieces.Events.Interfaces;
using svanderweele.Core.Pieces.Selection.Services;
using svanderweele.Core.Pieces.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity.Views
{
    public class UnityBaseGameView : MonoBehaviour, IViewController, IEventListener, IVisibleListener,
        IGameDestroyedListener, IPositionListener, ISpriteListener
    {
        protected Contexts Contexts;
        private GameEntity _entity;
        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void Link(Contexts contexts, IEntity entity)
        {
            if (_entity != null)
            {
                Unlink();
            }

            _entity = (GameEntity) entity;

            //TODO : How to solve this repeated code?
            var evtListeners = GetComponents<IEventListener>();

            foreach (IEventListener listener in evtListeners)
            {
                listener.RegisterEvents(contexts, entity);
            }

            var collisionListeners = GetComponents<ICollisionController>();

            foreach (var collisionController in collisionListeners)
            {
                collisionController.Initialize(contexts, entity);
            }

            var selectionController = GetComponents<ISelectionController>();

            foreach (var controller in selectionController)
            {
                controller.Initialize(contexts, entity);
            }
        }

        public void Unlink()
        {
            _entity.RemoveVisibleListener(this);
            _entity.RemoveGameDestroyedListener(this);
            _entity = null;
        }

        public int GetEntityId()
        {
            return _entity.id.value;
        }

        public void RegisterEvents(Contexts contexts, IEntity entity)
        {
            _entity.AddSpriteListener(this);
            _entity.AddPositionListener(this);
            _entity.AddVisibleListener(this);
            _entity.AddGameDestroyedListener(this);
            RegisterEvents(_entity);
        }

        protected virtual void RegisterEvents(GameEntity entity)
        {
        }

        public void OnVisible(GameEntity entity, bool isVisible)
        {
            gameObject.SetActive(isVisible);
        }

        public void OnDestroyed(GameEntity entity)
        {
            Destroy(gameObject);
        }

        public void OnPosition(GameEntity entity, float x, float y)
        {
            transform.position = new Vector2(x, y);
        }

        public void OnSprite(GameEntity entity, string name)
        {
            _spriteRenderer.sprite = Resources.Load<Sprite>(name);
        }
    }
}