using svanderweele.Mine.Core.Pieces.Time;
using svanderweele.Mine.Core.Services.Selection;
using svanderweele.Mine.Core.Services.Time;

namespace svanderweele.Mine.Game.Services
{
    public class SelectionService : ISelectionService
    {
        private const float SELECTION_HOVER_OUT_THRESHOLD = 0.25f;
        private const float SELECTION_HELD_DOWN_THRESHOLD = 0.25f;
        private const float SELECTION_HOVER_SELECT_THRESHOLD = 0.75f;


        private readonly Contexts _contexts;

        private ITimeService _timeService
        {
            get { return _contexts.meta.timeService.time; }
        }

        public SelectionService(Contexts contexts)
        {
            _contexts = contexts;
        }

        public bool IsHoverOver(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            return entity.hasSelectionOver;
        }

        public bool IsHoverOut(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            if (entity.hasSelectionOut == false)
            {
                return false;
            }

            var timeDifference = _timeService.GetTime() - entity.selectionOut.timeSinceOut;
            return timeDifference <= SELECTION_HOVER_OUT_THRESHOLD;
        }

        public bool IsHoverSelect(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            if (entity.hasSelectionOver == false)
            {
                return false;
            }

            var timeDifference = _timeService.GetTime() - entity.selectionOver.timeSinceOver;
            return timeDifference >= SELECTION_HOVER_SELECT_THRESHOLD;
        }

        public bool IsSelectionDown(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            return entity.hasSelectionDown;
        }

        public bool IsSelectionUp(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            return entity.hasSelectionUp;
        }

        public bool IsSelectionHeld(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            if (entity.hasSelectionDown == false)
            {
                return false;
            }

            var timeDifference = _timeService.GetTime() - entity.selectionDown.timeSinceDown;
            return timeDifference >= SELECTION_HELD_DOWN_THRESHOLD;
        }


        public void SetSelectionDown(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            entity.ReplaceSelectionDown(_timeService.GetTime());
            if (entity.hasSelectionUp)
                entity.RemoveSelectionUp();
        }

        public void SetSelectionUp(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            entity.AddSelectionUp(_timeService.GetTime());
            if (entity.hasSelectionDown)
                entity.RemoveSelectionDown();
        }

        public void SetSelectionOver(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            entity.AddSelectionOver(_timeService.GetTime());
            if (entity.hasSelectionOut)
                entity.RemoveSelectionOut();
        }

        public void SetSelectionOut(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            entity.AddSelectionOut(_timeService.GetTime());
            if (entity.hasSelectionOver)
                entity.RemoveSelectionOver();
        }
    }
}