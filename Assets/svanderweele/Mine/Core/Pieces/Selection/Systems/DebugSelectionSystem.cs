using Entitas;

namespace svanderweele.Mine.Core.Pieces.Selection.Systems
{
    public class DebugSelectionSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        public DebugSelectionSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        private void AddOrReplace(GameEntity entity, float r, float g, float b, float a)
        {
            if (entity.hasSpriteColor == false)
            {
                entity.AddSpriteColor(r, g, b, a);
            }
            else
            {
                entity.ReplaceSpriteColor(r, g, b, a);
            }
        }

        public void Execute()
        {
            var entities = _contexts.game.GetEntities(GameMatcher.AnyOf(GameMatcher.SelectionDown,
                GameMatcher.SelectionOut, GameMatcher.SelectionOver, GameMatcher.SelectionOut));

            foreach (var gameEntity in entities)
            {
                var entityIndex = gameEntity.id.value;
                var entity = gameEntity;

                AddOrReplace(entity, 1.0f, 1.0f, 1.0f, 1.0f);

                if (_contexts.meta.selectionService.selection.IsHoverOver(entityIndex))
                {
                    AddOrReplace(entity, 1.0f, 0.0f, 1.0f, 1.0f);
                }

                if (_contexts.meta.selectionService.selection.IsHoverSelect(entityIndex))
                {
                    AddOrReplace(entity, 1f, 1f, 0, 1.0f);
                }


                if (_contexts.meta.selectionService.selection.IsSelectionDown(entityIndex))
                {
                    AddOrReplace(entity, 1, 0, 0, 1.0f); // red
                }

                if (_contexts.meta.selectionService.selection.IsSelectionHeld(entityIndex))
                {
                    AddOrReplace(entity, 0, 0, 1, 1.0f); //blue
                }

                if (_contexts.meta.selectionService.selection.IsSelectionUp(entityIndex))
                {
                    AddOrReplace(entity, 0.5f, 0.5f, 0, 1.0f); // yellow
                }

                if (_contexts.meta.selectionService.selection.IsHoverOut(entityIndex))
                {
                    AddOrReplace(entity, 1f, 1f, 1f, 1.0f); //white
                }

                {
                }
            }
        }
    }
}