using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using svanderweele.Mine.GameEditor.Unity.Data;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Components
{
    [MapEditor, Event(true)]
    public class AssetBayAssetsComponent : IComponent
    {
        public List<IMapEditorAssetData> assets;
    }
}