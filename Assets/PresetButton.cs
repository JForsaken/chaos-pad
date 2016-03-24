using UnityEngine;
using System.Collections;

public class PresetButton : MonoBehaviour {

	public Preset preset;
	public SoundLibrary soundLibrary;

	void OnMouseDown() {
		soundLibrary.SetPreset (preset);
	}

}
