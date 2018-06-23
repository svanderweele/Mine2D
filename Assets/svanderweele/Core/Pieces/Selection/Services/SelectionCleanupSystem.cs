using Entitas;

namespace svanderweele.Core.Pieces.Selection.Services
{
    public class SelectionCleanupSystem : ICleanupSystem
    {
        private readonly Contexts _contexts;

        public SelectionCleanupSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        
        public void Cleanup()
        {
            var remove = _contexts.game.GetEntities(GameMatcher.SelectionUp);
            foreach (var gameEntity in remove)
            {
                gameEntity.RemoveSelectionUp();
            }
        }

    }
}