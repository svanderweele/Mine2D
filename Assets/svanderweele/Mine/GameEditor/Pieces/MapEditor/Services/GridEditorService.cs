using System.Collections.Generic;
using svanderweele.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Core.Pieces.GridEditor.Service.Core;
using svanderweele.Mine.GameEditor.Unity.Data;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Services
{
    public class GridEditorService : IGridEditorService
    {
        private readonly Contexts _contexts;
        private readonly IGridEditorAssetLoader _assetLoader;
        private readonly IGridEditorNavigationService _navigation;
        private readonly IGridEditorToolService _toolService;
        private readonly IGridEditorObjectService _objectService;

        public GridEditorService(Contexts contexts, IGridEditorAssetLoader assetLoader, IGridEditorToolService toolService, IGridEditorNavigationService navigation, IGridEditorObjectService objectService)
        {
            _contexts = contexts;
            _assetLoader = assetLoader;
            _toolService = toolService;
            _navigation = navigation;
            _objectService = objectService;
        }
        
        public List<IMapEditorAssetData> GetAssets()
        {
            return _assetLoader.GetAssets();
        }

        public void SetPage(int page)
        {
            _navigation.SetPage(page);
        }

        public void SetTool(string id)
        {
            _toolService.SetTool(id);
        }

        public void SetObject(IGridEditorObjectViewController obj)
        {
            _objectService.SetObject(obj);
        }

    }
}