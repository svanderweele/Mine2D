using svanderweele.Mine.Game.Factories.Tile;

namespace svanderweele.Mine.Game.Factories
{
    public class GameFactories 
    {
        
        public readonly ITileFactory Tile;

        public GameFactories(ITileFactory tile)
        {
            Tile = tile;
        }

    }
}