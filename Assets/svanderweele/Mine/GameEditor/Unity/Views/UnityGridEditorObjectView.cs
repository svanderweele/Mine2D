using Entitas;
using svanderweele.Mine.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.Game.Unity;
using svanderweele.Mine.GameEditor.Unity.Data;
using UnityEngine;
using UnityEngine.UI;

namespace svanderweele.Mine.GameEditor.Unity.Views
{
    public class UnityGridEditorObjectView : UnityMapEditorBaseView, IGridEditorObjectViewController, IAssetDataListener, IEventListener
    {
        private Image _renderer;

        private void Awake()
        {
            _renderer = GetComponent<Image>();
        }


        public void OnAssetData(MapEditorEntity entity, IMapEditorAssetData assetData)
        {
            _renderer.sprite = Resources.Load<Sprite>(assetData.GetDisplaySpritePath());
        }

        public void RegisterEvents(Contexts contexts, IEntity entity)
        {
            Entity.AddAssetDataListener(this);
        }
    }
}