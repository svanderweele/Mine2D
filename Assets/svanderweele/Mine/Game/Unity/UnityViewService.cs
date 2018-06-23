using Entitas;
using svanderweele.Core.Pieces.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityViewService : IViewService
    {

        public void LoadAsset(Contexts contexts, IEntity entity, string assetPath)
        {
            var go = GameObject.Instantiate(Resources.Load<GameObject>(assetPath));

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