using System.Collections.Generic;
using Entitas;
using svanderweele.Mine.Game.Utils;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Actions.CreateMapEditor
{
    public class CreateMapEditorSystem : ReactiveSystem<ActionEntity>
    {
        private readonly Contexts _contexts;

        public CreateMapEditorSystem(Contexts contexts) : base(contexts.action)
        {
            _contexts = contexts;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher.AllOf(ActionMatcher.ActionCreateMapEditor)
                .NoneOf(ActionMatcher.Consumed, ActionMatcher.Delay));
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.isAction && entity.isConsumed == false && entity.isDestroyed == false &&
                   entity.hasDelay == false;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                //Initiate Map Editor
                var mapEditorEntity = _contexts.mapEditor.CreateEntity();
                _contexts.meta.viewService.instance.LoadAsset(_contexts, mapEditorEntity,
                    GlobalVariables.ResourcesAssetsPath + "prefabs/grid-editor");
                var view = mapEditorEntity.mapEditor.view;

                //Creating asset bay
                var assetBay = view.AssetBay;
                var assetBayEntity = _contexts.mapEditor.CreateEntity();
                assetBay.Link(_contexts, assetBayEntity);
                mapEditorEntity.AddAssetBay(assetBayEntity.id.value);


                actionEntity.isConsumed = true;
            }
        }
    }
}