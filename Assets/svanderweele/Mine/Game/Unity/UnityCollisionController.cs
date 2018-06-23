using Entitas;
using svanderweele.Mine.Core.Pieces.View;
using svanderweele.Mine.Core.Services.Collision;
using svanderweele.Mine.Core.Services.View;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnityCollisionController : MonoBehaviour, ICollisionController
    {
        private GameEntity _entity;
        private ICollisionService _collisionService;

        public void Initialize(Contexts contexts, IEntity entity)
        {
            _collisionService = contexts.meta.collisionService.service;
            _entity = (GameEntity) entity;
        }


        public void OnCollisionEnter2D(Collision2D other)
        {
            _collisionService.OnCollisionEnter(_entity.id.value, GetTargetEntityId(other));
        }

        private int GetTargetEntityId(Collision2D other)
        {
            var targetGo = other.gameObject;
            var targetView = targetGo.GetComponent<IViewController>();
            return targetView.GetEntityId();
        }


        private void OnCollisionExit2D(Collision2D other)
        {
            var go = other.gameObject;
            var view = go.GetComponent<IViewController>();
            _collisionService.OnCollisionExit(_entity.id.value, GetTargetEntityId(other));
        }
    }
}