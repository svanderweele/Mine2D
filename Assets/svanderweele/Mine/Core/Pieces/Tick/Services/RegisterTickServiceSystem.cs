using Entitas;
using UnityEngine;

namespace svanderweele.Mine.Core.Pieces.Tick.Services
{
    public class RegisterTickServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ITickService _tickService;

        public RegisterTickServiceSystem(Contexts contexts, ITickService tickService)
        {
            _contexts = contexts;
            _tickService = tickService;
        }
        
        public void Initialize()
        {
            Debug.Log(_tickService);
            _contexts.meta.ReplaceTickService(_tickService);
        }
    }
}