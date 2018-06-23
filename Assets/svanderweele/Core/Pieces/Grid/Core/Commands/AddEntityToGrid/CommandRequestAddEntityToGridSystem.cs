using System.Collections.Generic;
using Entitas;
using svanderweele.Core.Pieces.Actions;
using svanderweele.Mine.Game.Utils;
using UnityEngine;

namespace svanderweele.Core.Pieces.Grid.Core.Actions.AddEntityToGrid
{
    public class ActionRequestAddEntityToGridSystem : ReactiveSystem<ActionEntity>
    {
        private readonly Contexts _contexts;

        public ActionRequestAddEntityToGridSystem(Contexts contexts) : base(contexts.action)
        {
            _contexts = contexts;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
        {
            return context.CreateCollector(ActionMatcher
                .AllOf(ActionMatcher.Action, ActionMatcher.ActionRequest,
                    ActionMatcher.ActionRequestAddEntityToGrid)
                .NoneOf(ActionMatcher.ActionDelay, ActionMatcher.ActionConsumed));
        }

        protected override bool Filter(ActionEntity entity)
        {
            return entity.isAction && entity.isDestroyed == false && entity.isActionConsumed == false &&
                   entity.isActionRequest;
        }

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                var entityId = actionEntity.actionRequestAddEntityToGrid.entityId;
                var entity = _contexts.game.GetEntityWithId(entityId);

                //Is entity of right type
                var gridId = actionEntity.actionRequestAddEntityToGrid.gridId;
                var grid = _contexts.grid.GetEntityWithId(gridId);

                var entityType = entity.gridTileType.type;
                var gridType = grid.gridTileType.type;

                if (GlobalVariables.ObjectType.Matches(entityType, gridType) == false)
                {
                    Debug.Log("Can't place tile on grid - Wrong Category " + entityType);
                    actionEntity.isActionConsumed = true;
                    return;
                }

                //Check if tile is vacant on layer
                int layer = actionEntity.actionRequestAddEntityToGrid.layer;
                var entitiesOnSameLayer = _contexts.game.GetEntitiesWithGridLayer(layer);
                var entitiesOnSameLayerIds = new List<int>();

                foreach (var gameEntity in entitiesOnSameLayer)
                {
                    entitiesOnSameLayerIds.Add(gameEntity.id.value);
                }


                bool collision = _contexts.meta.collisionService.service.AreColliding(entityId, entitiesOnSameLayerIds);

                if (collision == false)
                {
                    var cmd = _contexts.action.CreateAction(0);
                    cmd.AddActionAddEntityToGrid(entityId, gridId, layer);
                    actionEntity.isActionConsumed = true;
                }
                else
                {
                    Debug.Log("Can't place Entity");
                    actionEntity.isActionConsumed = true;
                }
            }
        }
    }
}