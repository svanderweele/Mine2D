
using Entitas;
using UnityEngine;

public class UnityViewService : IViewService
{
    public void LoadAsset(Contexts contexts, IEntity entity, string assetName)
    {
        var go = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/" + assetName));
        var view = go.GetComponent<IViewController>();

        if (view != null)
        {
            view.Link(contexts, entity);
        }

        var events = go.GetComponents<IEventListener>();
        foreach (IEventListener evt in events)
        {
            evt.RegisterListeners(entity);
        }

    }
}