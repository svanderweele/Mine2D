using UnityEngine;

namespace svanderweele.Mine.Testing.InputBindTest
{
    public class MainTest : MonoBehaviour
    {
        private InputBindConfigurationTest _test;

        private void Awake()
        {
            _test = new InputBindConfigurationTest();
        }
    }
}