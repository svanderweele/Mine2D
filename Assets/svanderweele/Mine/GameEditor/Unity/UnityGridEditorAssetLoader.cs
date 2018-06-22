using System.Collections.Generic;
using svanderweele.Mine.Core.Pieces.Grid.GridEditor.Interfaces;
using svanderweele.Mine.Engine.Unity.MapEditor;
using svanderweele.Mine.GameEditor.Unity.Data;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity
{
    public class UnityGridEditorAssetLoader : IGridEditorAssetLoader
    {
        private string searchDirectory = "data/assets/";

        public List<IMapEditorAssetData> GetAssets()
        {
            var gridAssets = new List<IMapEditorAssetData>();

            var assets = Resources.LoadAll<UnityMapEditorAssetData>(searchDirectory);
            foreach (var asset in assets)
            {
                gridAssets.Add(asset);
            }

            return gridAssets;
        }
    }
}