using svanderweele.Mine.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.Game.Unity;

namespace svanderweele.Mine.Engine.Unity.MapEditor.Views.GridEditor
{
    public class UnityGridEditorView : UnityBaseGameView, IGridEditorView
    {
        public IGridEditorAssetBay AssetBay { get; private set; }

        private void Awake()
        {
            AssetBay = GetComponentInChildren<IGridEditorAssetBay>();
        }


    }
}