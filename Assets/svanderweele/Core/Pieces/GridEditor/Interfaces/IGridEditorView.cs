using svanderweele.Core.Pieces.View;

namespace svanderweele.Core.Pieces.GridEditor.Interfaces
{
    public interface IGridEditorView : IViewController
    {
        IGridEditorAssetBay AssetBay { get; }
    }
}