using Entitas;
using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.Core.Services.Selection;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public abstract class UnityBaseGameView : MonoBehaviour, IViewController, IEventListener, IVisibleListener,
        IGameDestroyedListener
    {
        protected Contexts Contexts;
        private GameEntity _entity;

        public void Link(Contexts contexts, IEntity entity)
        {
            if (_entity != null)
            {
                Unlink();
            }

            _entity = (GameEntity) entity;

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
            _entity.AddVisibleListener(this);
            _entity.AddGameDestroyedListener(this);
            RegisterEvents(_entity);
        }

        public virtual void RegisterEvents(GameEntity entity)
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
    }
}