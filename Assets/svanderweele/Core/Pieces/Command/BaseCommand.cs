using Entitas;

namespace svanderweele.Core.Pieces.Command
{
    public abstract class BaseCommand : ICommand
    {
        private Contexts _contexts;

        protected BaseCommand(Contexts context)
        {
            _contexts = context;
        }

        public bool IsForced { get; set; }

        public void DoCommand(bool forced = false)
        {
            if (IsForced || forced)
            {
                AddDoAction(_contexts.action.CreateEntity());
            }
            else
            {
                AddDoRequest(_contexts.request.CreateEntity());
            }
        }

        public void UndoCommand(bool forced = false)
        {
            if (IsForced || forced)
            {
                AddUndoAction(_contexts.action.CreateEntity());
            }
            else
            {
                AddUndoRequest(_contexts.request.CreateEntity());
            }
        }


        protected abstract void AddDoRequest(RequestEntity entity);
        protected abstract void AddDoAction(ActionEntity  entity);
        protected abstract void AddUndoAction(ActionEntity entity);
        protected abstract void AddUndoRequest(RequestEntity entity);
    }
}