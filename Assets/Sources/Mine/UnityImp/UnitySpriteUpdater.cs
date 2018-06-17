

using UnityEngine;

public class UnitySpriteUpdater : MonoBehaviour, ISpriteListener
{
    private SpriteRenderer _spriteRenderer;
    private string _spriteName;


    public void OnSprite(GameEntity entity, string spriteName)
    {
        if(this._spriteName == spriteName){
            return;
        }

        var sprite = Resources.Load<Sprite>("Sprites/"+spriteName);
        _spriteRenderer.sprite = sprite;
        this._spriteName = spriteName;
    }
}