using UnityEngine;
using System.Collections;

public class PlayRecord : MonoBehaviour {

	void OnMouseDown() {
		EventManager.instance.TogglePlayLastRecord ();
	}
}
