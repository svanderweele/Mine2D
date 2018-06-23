using Entitas;
using UnityEngine;

namespace svanderweele.Core.Pieces.Selection.Services
{
    public class RegisterSelectionServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ISelectionService _selection;

        public RegisterSelectionServiceSystem(Contexts contexts, ISelectionService selection)
        {
            _contexts = contexts;
            _selection = selection;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceSelectionService(_selection);
            Debug.Log("Selection Initialized " + _selection);
        }
    }
}