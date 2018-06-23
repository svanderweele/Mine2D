using svanderweele.Mine.Game.Factories.Tile;

namespace svanderweele.Mine.Game.Factories
{
    public class RegisterFactoriesSystem : Feature
    {
        public RegisterFactoriesSystem(Contexts contexts, GameFactories gameFactories)
        {
            Add(new RegisterTileFactorySystem(contexts, gameFactories.Tile));
        }
    }
}