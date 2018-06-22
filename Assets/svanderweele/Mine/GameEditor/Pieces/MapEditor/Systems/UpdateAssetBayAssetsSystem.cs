using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Entitas;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Systems
{
    public class UpdateAssetBayAssetsSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public UpdateAssetBayAssetsSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Tick);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasTick;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var tickEntity in entities)
            {
                if (_contexts.meta.tickService.instance.IsTick(tickEntity, TickEnum.MapEditor_AssetLoading) == false)
                {
                    return;
                }
                var gameEntity = _contexts.mapEditor.GetEntities(MapEditorMatcher.AssetBay).Single();
                var assets = _contexts.meta.gridEditorService.service.GetAssets();

                var mapEditor = _contexts.mapEditor.GetEntityWithAssetBay(gameEntity.assetBay.id);
                var mapEditorView = mapEditor.mapEditor.view;

                var views = mapEditorView.AssetBay.CreateViews(assets.Count);

                for (int i = 0; i < assets.Count; i++)
                {
                    var asset = assets[i];
                    var view = views[i];
                    var entity = _contexts.mapEditor.CreateEntity();
                    _contexts.meta.viewService.instance.LinkAsset(_contexts, entity, view);
                    entity.AddAssetData(asset);
                }

            }
        }
    }
}