using UnityEngine;

namespace svanderweele.Mine.Utilities
{
	[ExecuteInEditMode]
	public class CanvasAutoAssignMainCamera : MonoBehaviour {

		void Awake ()
		{
			GetComponent<Canvas>().worldCamera = Camera.main;
		}
	
	}
}
