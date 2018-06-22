using Entitas;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;
using Vector2 = svanderweele.Mine.Game.Utils.Math.Vector2;

namespace svanderweele.Mine.Game.Unity.GridEditor
{
    public class UnityGridEditorObjectView : UnityBaseGameView
    {
        private GameEntity _entity;
        private Contexts _contexts;

        public void Link(Contexts contexts, IEntity entity)
        {
            _contexts = contexts;
            _entity = (GameEntity) entity;
        }

        public int GetEntityId()
        {
            return _entity.id.value;
        }

    }
}