using svanderweele.Mine.Core.Pieces.GridEditor.Interfaces;
using svanderweele.Mine.GameEditor.Unity.Data;
using UnityEditor;
using UnityEngine;

namespace svanderweele.Mine.Engine.Unity.MapEditor
{
    [CreateAssetMenu(menuName = "Mine2D/Map Editor/Create Asset Data")]
    public class UnityMapEditorAssetData : ScriptableObject, IMapEditorAssetData
    {
        public Sprite DisplaySprite;
        public string DisplayName;
        public GameObject Prefab;

        public string GetName()
        {
            return DisplayName;
        }

        public string GetAssetPath()
        {
            return GetAssetResourcesPath(Prefab);
        }

        public string GetDisplaySpritePath()
        {
            return GetAssetResourcesPath(DisplaySprite);
        }

        public string GetAssetResourcesPath(Object obj)
        {
            var resourcesPath = AssetDatabase.GetAssetPath(obj);
            resourcesPath = resourcesPath.Substring(resourcesPath.IndexOf("Resources/") + 10);
            resourcesPath = resourcesPath.Substring(0, resourcesPath.IndexOf(".")); //removing extension
            return resourcesPath;
        }
    }
}