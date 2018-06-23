using Entitas;
using svanderweele.Core.Pieces.GridEditor.Interfaces;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity.Views
{
    public class UnityMapEditorView : UnityMapEditorBaseView, IGridEditorView
    {
        public IGridEditorAssetBay AssetBay { get; private set; }

        private void Awake()
        {
            AssetBay = GetComponentInChildren<IGridEditorAssetBay>();
        }

        protected override void OnLink(Contexts contexts, MapEditorEntity entity)
        {
            entity.AddMapEditor(this);
        }
    }
}