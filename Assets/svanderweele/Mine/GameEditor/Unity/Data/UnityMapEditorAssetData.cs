using svanderweele.Mine.Core.Pieces.Grid.GridEditor.Data;
using UnityEngine;

namespace svanderweele.Mine.Engine.Unity.MapEditor
{
    [CreateAssetMenu(menuName = "Mine2D/Map Editor/Create Asset Data")]
    public class UnityMapEditorAssetData :ScriptableObject
    {
        public GridEditorAssetData AssetData;
        public Sprite DisplaySprite;
    }
}