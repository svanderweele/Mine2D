using svanderweele.Mine.Core.Pieces.Grid.GridEditor.Interfaces;
using svanderweele.Mine.Core.Pieces.Grid.GridEditor.Service;
using svanderweele.Mine.Core.Pieces.GridEditor.Interfaces;

namespace svanderweele.Mine.Core.Pieces.GridEditor.Service
{
    public interface IGridEditorService : IGridEditorAssetLoader, IGridEditorToolService, IGridEditorNavigationService,
        IGridEditorObjectService
    {

        void SetupEditor(IGridEditorView view);
    }
}