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
        }

        public void LinkAsset(Contexts contexts, IEntity entity, IViewController controller)
        {
            controller.Unlink();
            controller.Link(contexts, entity);
        }
    }
}