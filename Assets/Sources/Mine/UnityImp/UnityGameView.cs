

using Entitas;
using UnityEngine;

public class UnityGameView : MonoBehaviour, IViewController, IEventListener, IPositionListener
{
    private Contexts _contexts;
    private GameEntity _entity;

    public void Link(Contexts contexts, IEntity entity)
    {
        _contexts = contexts;
        _entity = (GameEntity) entity;
    }

    public void RegisterListeners(IEntity entity)
    {
        _entity.AddPositionListener(this);
    }

    public void OnPosition(GameEntity entity, float x, float y)
    {
        transform.position = new Vector2(x, y);
    }

}