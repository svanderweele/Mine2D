using System.Collections.Generic;
using svanderweele.Mine.Core.Pieces.Grid.GridEditor.Data;
using svanderweele.Mine.Core.Pieces.Grid.GridEditor.Interfaces;
using svanderweele.Mine.Engine.Unity.MapEditor;
using UnityEditor;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity
{
    public class UnityGridEditorAssetLoader : IGridEditorAssetLoader
    {
        private string searchDirectory = "data/map-editor/assets/";

        public List<GridEditorAssetData> GetAssets()
        {
            var gridAssets = new List<GridEditorAssetData>();

            var assets = Resources.LoadAll<UnityMapEditorAssetData>(searchDirectory);
            foreach (var asset in assets)
            {
                var spritePath = AssetDatabase.GetAssetPath(asset.DisplaySprite);
                spritePath = spritePath.Substring(spritePath.IndexOf("Resources/") + 10);
                Debug.Log("Sprite Path " + spritePath);
                gridAssets.Add(asset.AssetData);
            }

            return gridAssets;
        }
    }
}