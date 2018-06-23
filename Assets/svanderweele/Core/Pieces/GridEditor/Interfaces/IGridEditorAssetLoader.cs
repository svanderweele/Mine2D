using System.Collections.Generic;
using svanderweele.Mine.GameEditor.Unity.Data;

namespace svanderweele.Core.Pieces.GridEditor.Interfaces
{
    public interface IGridEditorAssetLoader
    {
        List<IMapEditorAssetData> GetAssets();
    }
}