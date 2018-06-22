using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Systems
{
    public class UpdateAssetBayAssetsSystem : ReactiveSystem<MapEditorEntity>
    {
        private readonly Contexts _contexts;

        public UpdateAssetBayAssetsSystem(Contexts contexts) : base(contexts.mapEditor)
        {
            _contexts = contexts;
        }

        protected override ICollector<MapEditorEntity> GetTrigger(IContext<MapEditorEntity> context)
        {
            return context.CreateCollector(MapEditorMatcher.AnyOf(MapEditorMatcher.AssetBayAssets, MapEditorMatcher.AssetBay));
        }

        protected override bool Filter(MapEditorEntity entity)
        {
            return entity.hasAssetBay;
        }

        protected override void Execute(List<MapEditorEntity> entities)
        {
            foreach (var mapEditorEntity in entities)
            {
                var assets = _contexts.meta.gridEditorService.service.GetAssets();
                var assetBay = _contexts.mapEditor.GetEntityWithId(mapEditorEntity.assetBay.id);
                

                if (assetBay.hasAssetBayAssets)
                {
                    assetBay.ReplaceAssetBayAssets(assets);
                }
                else
                {
                    assetBay.AddAssetBayAssets(assets);
                }
            }
        }
    }
}