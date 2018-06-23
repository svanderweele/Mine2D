using System.Collections.Generic;
using svanderweele.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.Game.Utils;
using svanderweele.Mine.GameEditor.Unity.Data;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Unity
{
    public class UnityMapEditorAssetLoader : IGridEditorAssetLoader
    {

        public List<IMapEditorAssetData> GetAssets()
        {
            var gridAssets = new List<IMapEditorAssetData>();

            var assets = Resources.LoadAll<UnityMapEditorAssetData>(GlobalVariables.MapEditorAssetDataPath);
            foreach (var asset in assets)
            {
                gridAssets.Add(asset);
            }

            return gridAssets;
        }
    }
}