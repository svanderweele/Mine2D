using Entitas;
using svanderweele.Mine.Game.Utils.Containers;

namespace svanderweele.Mine.Game.Pieces.Selection.Systems
{
    public class UpdateSelectionColorSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        public UpdateSelectionColorSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        private void AddOrReplace(GameEntity entity, Color color)
        {
            if (entity.hasSpriteColor == false)
            {
                entity.AddSpriteColor(color.r, color.g, color.b, color.a);
            }
            else
            {
                entity.ReplaceSpriteColor(color.r, color.g, color.b, color.a);
            }
        }

        public void Execute()
        {
            var entities = _contexts.game.GetEntities(GameMatcher.AllOf(GameMatcher.SelectionColor).AnyOf(
                GameMatcher.SelectionDown,
                GameMatcher.SelectionOut, GameMatcher.SelectionOver, GameMatcher.SelectionOut));

            foreach (var gameEntity in entities)
            {
                var entityIndex = gameEntity.id.value;
                var entity = gameEntity;

                var color = gameEntity.selectionColor;

                AddOrReplace(entity, Color.white);

                if (_contexts.meta.selectionService.selection.IsHoverOver(entityIndex))
                {
                    AddOrReplace(entity, color.selectionHoverOut);
                }

                if (_contexts.meta.selectionService.selection.IsHoverSelect(entityIndex))
                {
                    AddOrReplace(entity, color.selectionHoverSelect);
                }

                if (_contexts.meta.selectionService.selection.IsSelectionDown(entityIndex))
                {
                    AddOrReplace(entity, color.selectionDown);
                }

                if (_contexts.meta.selectionService.selection.IsSelectionHeld(entityIndex))
                {
                    AddOrReplace(entity, color.selectionHeld);
                }

                if (_contexts.meta.selectionService.selection.IsSelectionUp(entityIndex))
                {
                    AddOrReplace(entity, color.selectionUp);
                }

                if (_contexts.meta.selectionService.selection.IsHoverOut(entityIndex))
                {
                    AddOrReplace(entity, color.selectionHoverOut);
                }

                {
                }
            }
        }
    }
}