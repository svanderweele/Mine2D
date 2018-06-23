namespace svanderweele.Core.Pieces.Actions
{
    public static class ActionContextExtension
    {

        public static ActionEntity CreateAction(this ActionContext context, float delay)
        {
            var action = context.CreateEntity();
            action.isAction = true;
            action.AddActionDelay(delay);
            return action;
        }

        public static ActionEntity CreateActionRequest(this ActionContext context, float delay)
        {
            var action = CreateAction(context, delay);
            action.isActionRequest = true;
            return action;
        }
    }
}