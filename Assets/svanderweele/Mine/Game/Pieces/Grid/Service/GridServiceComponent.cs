using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Pieces.Grid.Service
{
    [Meta, Unique]
    public class GridServiceComponent : IComponent
    {
        public IGridService service;
    }
}