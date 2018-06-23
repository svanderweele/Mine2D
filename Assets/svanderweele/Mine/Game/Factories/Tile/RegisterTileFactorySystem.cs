using Entitas;

namespace svanderweele.Mine.Game.Factories.Tile
{
    public class RegisterTileFactorySystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ITileFactory _tileFactory;

        public RegisterTileFactorySystem(Contexts contexts, ITileFactory tileFactory)
        {
            _contexts = contexts;
            _tileFactory = tileFactory;
        }
        
        public void Initialize()
        {
            _contexts.factory.ReplaceTileFactory(_tileFactory);
        }
    }
}