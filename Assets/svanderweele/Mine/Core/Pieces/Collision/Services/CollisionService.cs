using System.Collections.Generic;
using svanderweele.Mine.Core.Services.Collision;
using UnityEngine;

namespace svanderweele.Mine.Game.Services
{
    public class CollisionService : ICollisionService
    {
        private readonly Contexts _contexts;

        public CollisionService(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void OnCollisionEnter(int entityAId, int entityBId)
        {
            var entityA = _contexts.game.GetEntityWithId(entityAId);
            AddCollision(entityA, entityBId);
        }

        public void OnCollisionExit(int entityAId, int entityBId)
        {
            var entityA = _contexts.game.GetEntityWithId(entityAId);
            RemoveCollision(entityA, entityBId);
        }

        public List<int> GetCollisions(int entityId)
        {
            var entity = _contexts.game.GetEntityWithId(entityId);
            if (entity.hasCollision)
            {
                return entity.collision.collisions;
            }
            return new List<int>();
        }

        public bool AreColliding(int entityAId, int entityBId)
        {
            var collisions = GetCollisions(entityAId);
            return collisions.IndexOf(entityBId) > -1;
        }

        public bool AreColliding(int entityAId, List<int> entities)
        {
            foreach (var entity in entities)
            {
                if (AreColliding(entityAId, entity))
                {
                    return true;
                }
            }

            return false;
        }

        private void AddCollision(GameEntity entity, int targetId)
        {
            var collisions = new List<int>();

            if (entity.hasCollision)
            {
                collisions = entity.collision.collisions;
            }

            if (collisions.IndexOf(targetId) == -1)
            {
                collisions.Add(targetId);
            }

            entity.ReplaceCollision(collisions);
        }

        public void RemoveCollision(GameEntity entity, int targetId)
        {
            if (entity.hasCollision == false)
            {
                Debug.LogError("RemoveCollision::Tried to remove collision but Entity has no collisions");
                return;
            }

            var collisions = entity.collision.collisions;
            var index = collisions.IndexOf(targetId);

            if (index == -1)
            {
                Debug.LogError("RemoveCollision [Entity Id: " + entity.id.value +
                               "]::Tried to remove collision that doesnt exist");
            }

            collisions.RemoveAt(index);
            entity.ReplaceCollision(collisions);
        }
    }
}