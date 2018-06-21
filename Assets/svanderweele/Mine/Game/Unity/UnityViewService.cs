using Entitas;
using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.Core.Services.Selection;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityViewService : IViewService
    {
        public void LoadAsset(Contexts contexts, IEntity entity, string assetName)
        {
            var go = GameObject.Instantiate(Resources.Load<GameObject>("prefabs/" + assetName));

            var view = go.GetComponent<IViewController>();

            if (view != null)
            {
                view.Link(contexts, entity);
            }

            var evtListeners = go.GetComponents<IEventListener>();

            foreach (IEventListener listener in evtListeners)
            {
                listener.RegisterEvents(contexts, entity);
            }


            var collisionListeners = go.GetComponents<ICollisionController>();

            foreach (var collisionController in collisionListeners)
            {
                collisionController.Initialize(contexts, entity);
            }

            var selectionController = go.GetComponents<ISelectionController>();
            
            foreach (var controller in selectionController)
            {
                controller.Initialize(contexts, entity);    
            }
        }
    }
}