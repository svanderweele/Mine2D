using System.Collections.Generic;
using Entitas;
using svanderweele.Mine.Core.Pieces.Commands;
using UnityEngine.iOS;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor
{
    public class RequestCreateMapEditorSystem : ReactiveSystem<CommandEntity>
    {
        private readonly Contexts _contexts;

        public RequestCreateMapEditorSystem(Contexts contexts) : base(contexts.command)
        {
            _contexts = contexts;
        }

        protected override ICollector<CommandEntity> GetTrigger(IContext<CommandEntity> context)
        {
            return context.CreateCollector(CommandMatcher
                .AllOf(CommandMatcher.CommandRequestCreateMapEditor, CommandMatcher.CommandRequest)
                .NoneOf(CommandMatcher.CommandDelay, CommandMatcher.CommandConsumed));
        }

        protected override bool Filter(CommandEntity entity)
        {
            return entity.hasCommandRequestCreateMapEditor && entity.isCommandRequest && entity.isCommand &&
                   entity.hasCommandDelay == false &&
                   entity.isCommandConsumed == false;
        }

        protected override void Execute(List<CommandEntity> entities)
        {
            foreach (var request in entities)
            {
                var command = _contexts.command.CreateCommand(0);
                command.AddCommandCreateMapEditor(request.commandRequestCreateMapEditor.gridId);
                request.isCommandConsumed = true;
            }
        }
    }
}