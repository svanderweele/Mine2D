using System.Collections.Generic;
using Entitas;

namespace svanderweele.Mine.Core.Pieces.Tick.Components
{
    [Game, MapEditor]
    public class TickComponent : IComponent
    {
        public Dictionary<TickEnum, Tick> ticks;
    }
}

public enum TickEnum
{
    AiMovement,
    PlayerMovement,
    MapEditor_AssetLoading
}