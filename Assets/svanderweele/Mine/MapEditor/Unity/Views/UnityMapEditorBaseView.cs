﻿using Entitas;
using svanderweele.Core.Pieces.Collision.Services;
using svanderweele.Core.Pieces.Events.Interfaces;
using svanderweele.Core.Pieces.Selection.Services;
using svanderweele.Core.Pieces.View;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity.Views
{
    public abstract class UnityMapEditorBaseView : MonoBehaviour, IViewController, IMapEditorDestroyedListener,
        IEventListener
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
            if (Entity == null)
            {
                return -1;
            }
            return Entity.id.value;
        }

        public void OnDestroyed(MapEditorEntity entity)
        {
            Debug.Log("Destroy gameobject");
            Destroy(gameObject);
        }

        public virtual void RegisterEvents(Contexts contexts, IEntity entity)
        {
            Debug.Log("Reigster event");
            Entity.AddMapEditorDestroyedListener(this);
        }
    }
}