using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Components
{
    [MapEditor]
    public class AssetBayComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int id;
    }
}