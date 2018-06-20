namespace svanderweele.Mine.Game.Commands
{
    public static class CommandContextExtension
    {

        public static CommandEntity CreateCommand(this CommandContext context, float delay)
        {
            var command = context.CreateEntity();
            command.isCommand = true;
            command.AddCommandDelay(delay);
            return command;
        }

        public static CommandEntity CreateCommandRequest(this CommandContext context, float delay)
        {
            var command = CreateCommand(context, delay);
            command.isCommandRequest = true;
            return command;
        }
    }
}