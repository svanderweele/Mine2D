using System.Collections.Generic;
using svanderweele.Mine.GameEditor.Unity.Data;

namespace svanderweele.Mine.Core.Pieces.Grid.GridEditor.Interfaces
{
    public interface IGridEditorAssetLoader
    {
        List<IMapEditorAssetData> GetAssets();
    }
}