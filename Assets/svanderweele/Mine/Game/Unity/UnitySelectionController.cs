using Entitas;
using svanderweele.Mine.Core.Services.Selection;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity
{
    public class UnitySelectionController : MonoBehaviour, ISelectionController
    {
        private GameEntity _entity;
        private ISelectionService _selectionService;

        public void Initialize(Contexts contexts, IEntity entity)
        {
            _selectionService = contexts.meta.selectionService.selection;
            _entity = (GameEntity) entity;
        }


        private void OnMouseDown()
        {
            _selectionService.SetSelectionDown(_entity.id.value);
        }

        private void OnMouseEnter()
        {
            _selectionService.SetSelectionOver(_entity.id.value);
        }


        private void OnMouseExit()
        {
            _selectionService.SetSelectionOut(_entity.id.value);
        }


        private void OnMouseUp()
        {
            _selectionService.SetSelectionUp(_entity.id.value);
        }
    }
}