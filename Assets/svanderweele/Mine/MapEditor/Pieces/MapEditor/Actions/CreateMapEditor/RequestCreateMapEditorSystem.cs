using System.Collections.Generic;
using Entitas;
using svanderweele.Core.Pieces.Actions;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Actions.CreateMapEditor
{
    public class RequestCreateMapEditorSystem : ReactiveSystem<RequestEntity>
    {
        private readonly Contexts _contexts;

        public RequestCreateMapEditorSystem(Contexts contexts) : base(contexts.request)
        {
            _contexts = contexts;
        }

        protected override ICollector<RequestEntity> GetTrigger(IContext<RequestEntity> context)
        {
            return context.CreateCollector(RequestMatcher
                .AllOf(RequestMatcher.RequestCreateMapEditor)
                .NoneOf(RequestMatcher.Consumed, RequestMatcher.Delay));
        }

        protected override bool Filter(RequestEntity entity)
        {
            return entity.hasRequestCreateMapEditor && entity.hasDelay == false &&
                   entity.isConsumed == false;
        }

        protected override void Execute(List<RequestEntity> entities)
        {
            foreach (var request in entities)
            {
                var action = _contexts.action.CreateAction(0);
                action.AddActionCreateMapEditor(request.requestCreateMapEditor.gridId);
                request.isConsumed = true;
            }
        }
    }
}