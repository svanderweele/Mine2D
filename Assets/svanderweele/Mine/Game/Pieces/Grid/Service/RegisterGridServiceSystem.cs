using Entitas;

namespace svanderweele.Mine.Game.Pieces.Grid.Service
{
    public class RegisterGridServiceSystem : IInitializeSystem
    {
        private readonly MetaContext _metaContext;
        private readonly IGridService _gridService;

        public RegisterGridServiceSystem(Contexts contexts, IGridService gridService)
        {
            _metaContext = contexts.meta;
            _gridService = gridService;
        }
        
        public void Initialize()
        {
            _metaContext.ReplaceGridService(_gridService);
        }
    }
}