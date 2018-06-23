using System.Collections.Generic;
using Entitas;
using svanderweele.Core.Pieces.Actions;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Actions.CreateMapEditor
{
    public class RequestCreateMapEditorSystem : ReactiveSystem<ActionEntity>
    {
        private readonly Contexts _contexts;

        public RequestCreateMapEditorSystem(Contexts contexts) : base(contexts.action)
        {
            _contexts = contexts;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher
                .AllOf(ActionMatcher.RequestCreateMapEditor, ActionMatcher.ActionRequest)
                .NoneOf(ActionMatcher.ActionDelay, ActionMatcher.ActionConsumed));
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.hasRequestCreateMapEditor && entity.isActionRequest && entity.isAction &&
                   entity.hasActionDelay == false &&
                   entity.isActionConsumed == false;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var request in entities)
            {
                var action = _contexts.action.CreateAction(0);
                action.AddActionCreateMapEditor(request.requestCreateMapEditor.gridId);
                request.isActionConsumed = true;
            }
        }
    }
}