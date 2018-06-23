using svanderweele.Mine.Game.Utils;

namespace svanderweele.Core.Pieces.Input.Binding
{
    public struct InputBind
    {
        public KeyId Key;
        public string Action;

        public InputBind(KeyId id, string action)
        {
            Key = id;
            Action = action;
        }

        public override string ToString()
        {
            return "Key ID: '" + Key + "'" + " Action: " + Action;
        }
    }
}