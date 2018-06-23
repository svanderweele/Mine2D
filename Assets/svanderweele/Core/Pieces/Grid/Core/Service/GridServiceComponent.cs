using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Core.Pieces.Grid.Core.Service
{
    [Meta, Unique]
    public class GridServiceComponent : IComponent
    {
        public IGridService service;
    }
}