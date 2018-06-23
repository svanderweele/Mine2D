using System;

namespace svanderweele.Core.Factories.Tile.Data
{
    public interface ITileCreationData
    {
        int Type { get; set; }

        //TODO : Implement health and tile sprite change based on health and adjacent tile states
        float Health { get; set; }
    }
    

}