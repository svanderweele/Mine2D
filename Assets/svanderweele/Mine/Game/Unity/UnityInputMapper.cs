using svanderweele.Core.Pieces.Input.Binding;
using svanderweele.Mine.Game.Utils;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityInputMapper : InputMapper<KeyCode>
    {
        protected override void AddKeys()
        {
            AddKeyMap(KeyId.W, KeyCode.W);
            AddKeyMap(KeyId.A, KeyCode.A);
            AddKeyMap(KeyId.S, KeyCode.S);
            AddKeyMap(KeyId.D, KeyCode.D);
            AddKeyMap(KeyId.Escape, KeyCode.Escape);
            AddKeyMap(KeyId.Space, KeyCode.Space);
        }
    }
}