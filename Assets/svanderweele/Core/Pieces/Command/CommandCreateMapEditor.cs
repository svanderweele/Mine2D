using Entitas;

namespace svanderweele.Core.Pieces.Command
{
    public class CommandCreateMapEditor : BaseCommand
    {
        private readonly int _gridId;

        public CommandCreateMapEditor(Contexts context, int gridId) : base(context)
        {
            _gridId = gridId;
        }

        protected override void AddDoRequest(RequestEntity entity)
        {
            entity.AddRequestCreateMapEditor(_gridId);
        }

        protected override void AddDoAction(ActionEntity entity)
        {
            entity.AddActionCreateMapEditor(_gridId);
        }

        protected override void AddUndoAction(ActionEntity entity)
        {
            throw new System.NotImplementedException();
        }

        protected override void AddUndoRequest(RequestEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}