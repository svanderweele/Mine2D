using svanderweele.Mine.GameEditor.Unity;
using UnityEngine;

namespace svanderweele.Mine.Testing.InputBindTest
{
    public class MainTest : MonoBehaviour
    {

        private void Awake()
        {
            var assetLoader = new UnityGridEditorAssetLoader();
            var assets = assetLoader.GetAssets();
        }
    }
}