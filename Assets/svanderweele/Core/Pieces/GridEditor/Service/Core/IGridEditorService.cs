using svanderweele.Core.Pieces.GridEditor.Interfaces;

namespace svanderweele.Core.Pieces.GridEditor.Service.Core
{
    public interface IGridEditorService : IGridEditorAssetLoader, IGridEditorToolService, IGridEditorNavigationService,
        IGridEditorObjectService
    {

    }
}