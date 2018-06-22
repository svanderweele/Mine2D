using System.Collections.Generic;
using svanderweele.Mine.Core.Pieces.Grid.GridEditor.Data;

namespace svanderweele.Mine.Core.Pieces.Grid.GridEditor.Interfaces
{
    public interface IGridEditorAssetLoader
    {
        List<GridEditorAssetData> GetAssets();
    }
}