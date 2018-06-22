using System.Collections.Generic;
using Entitas;
using svanderweele.Mine.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.Core.Services.Events;
using svanderweele.Mine.GameEditor.Unity.Data;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity.Views
{
    public class UnityAssetBayView : UnityMapEditorBaseView, IGridEditorAssetBay, IAssetBayAssetsListener,
        IEventListener
    {
        [SerializeField] private GameObject _assetUiPrefab;
        [SerializeField] private Transform _assetContainerTransform;


        public List<IGridEditorObjectViewController> CreateViews(int amount)
        {
            var list = new List<IGridEditorObjectViewController>();

            for (int i = 0; i < amount; i++)
            {
                //TODO : How to create entities in systems rather than monos?
                var obj = GameObject.Instantiate(_assetUiPrefab, _assetContainerTransform);
                var view = obj.GetComponent<IGridEditorObjectViewController>();
                var entity = Contexts.mapEditor.CreateEntity();
                view.Link(Contexts, entity);
                list.Add(view);
            }

            return list;
        }

        public void OnAssetBayAssets(MapEditorEntity entity, List<IMapEditorAssetData> assets)
        {
            var views = CreateViews(assets.Count);

            for (var index = 0; index < assets.Count; index++)
            {
                var asset = assets[index];
                var view = views[index];

                var assetUiObject = Contexts.mapEditor.GetEntityWithId(view.GetEntityId());
                assetUiObject.AddAssetData(asset);
            }
        }

        public void RegisterEvents(Contexts contexts, IEntity entity)
        {
            Entity.AddAssetBayAssetsListener(this);
        }
    }
}