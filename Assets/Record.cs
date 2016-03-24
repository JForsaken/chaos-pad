using UnityEngine;
using System.Collections;

public class Record : MonoBehaviour {
	
	void OnMouseDown() {
		EventManager.instance.ToggleRecord ();
	}
}
