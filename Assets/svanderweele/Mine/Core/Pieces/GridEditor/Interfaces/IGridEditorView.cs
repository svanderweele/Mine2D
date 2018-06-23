using svanderweele.Mine.Core.Pieces.View;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Pieces.GridEditor.Interfaces
{
    public interface IGridEditorView : IViewController
    {
        IGridEditorAssetBay AssetBay { get; }
    }
}