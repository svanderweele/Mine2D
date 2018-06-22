using UnityEngine;

namespace svanderweele.Mine.Utilities
{
	public class CanvasAutoAssignMainCamera : MonoBehaviour {

		void Awake ()
		{
			GetComponent<Canvas>().worldCamera = Camera.main;
		}
	
	}
}
