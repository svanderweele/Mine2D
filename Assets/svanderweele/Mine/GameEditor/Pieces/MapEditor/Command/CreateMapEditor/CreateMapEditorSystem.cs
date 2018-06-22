using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor
{
    public class CreateMapEditorSystem : ReactiveSystem<CommandEntity>
    {
        private readonly Contexts _contexts;

        public CreateMapEditorSystem(Contexts contexts) : base(contexts.command)
        {
            _contexts = contexts;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher.AllOf(CommandMatcher.CommandCreateMapEditor)
                .NoneOf(CommandMatcher.CommandConsumed, CommandMatcher.CommandDelay));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.isCommand && entity.isCommandConsumed == false && entity.isDestroyed == false && entity.hasCommandDelay == false;
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var commandEntity in entities)
            {
                //Initiate Map Editor
                var mapEditorEntity = _contexts.mapEditor.CreateEntity();
                _contexts.meta.viewService.instance.LoadAsset(_contexts, mapEditorEntity, "prefabs/grid-editor");
                var view = mapEditorEntity.mapEditor.view;
                
                //Creating asset bay
                var assetBay = view.AssetBay;
                var assetBayEntity = _contexts.mapEditor.CreateEntity();
                assetBay.Link(_contexts, assetBayEntity);
                mapEditorEntity.AddAssetBay(assetBayEntity.id.value);

                
                commandEntity.isCommandConsumed = true;

            }
        }
    }
}