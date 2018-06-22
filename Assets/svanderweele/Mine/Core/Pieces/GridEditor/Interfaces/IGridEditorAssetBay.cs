using System.Collections.Generic;

namespace svanderweele.Mine.Core.Pieces.GridEditor.Interfaces
{
    public interface IGridEditorAssetBay
    {
        List<IGridEditorObjectViewController> CreateViews(int amount);
    }
}