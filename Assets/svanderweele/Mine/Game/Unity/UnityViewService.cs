using Entitas;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityViewService : IViewService
    {
        public void LoadAsset(Contexts contexts, IEntity entity, string assetName)
        {
            var go = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/"+assetName));

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
        }
    }
}