using System.Collections.Generic;
using svanderweele.Core.Pieces.View;

namespace svanderweele.Core.Pieces.GridEditor.Interfaces
{
    public interface IGridEditorAssetBay : IViewController
    {
        List<IGridEditorObjectViewController> CreateViews(int amount);
        List<IGridEditorObjectViewController> GetCurrentViews();
    }
}