using Entitas;
using svanderweele.Mine.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.Core.Services.Selection;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity.Views
{
    public abstract class UnityMapEditorBaseView : MonoBehaviour, IViewController
    {
        protected Contexts Contexts;
        protected MapEditorEntity Entity;

        public void Link(Contexts contexts, IEntity entity)
        {
            Contexts = contexts;
            Entity = (MapEditorEntity) entity;

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

            OnLink(Contexts, Entity);
        }

        protected virtual void OnLink(Contexts contexts, MapEditorEntity entity)
        {
        }

        public void Unlink()
        {
            Entity = null;
        }

        public int GetEntityId()
        {
            return Entity.id.value;
        }
    }
}