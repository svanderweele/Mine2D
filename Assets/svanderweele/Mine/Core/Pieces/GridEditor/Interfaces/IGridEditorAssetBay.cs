using System.Collections.Generic;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Pieces.GridEditor.Interfaces
{
    public interface IGridEditorAssetBay : IViewController
    {
        List<IGridEditorObjectViewController> CreateViews(int amount);
    }
}