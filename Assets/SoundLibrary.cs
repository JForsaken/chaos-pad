using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class SoundLibrary : MonoBehaviour {
	public List<Preset> Library = new List<Preset> ();
	public List<Button> buttons = new List<Button> ();

	public void SetPreset(Preset preset) {
		for (int i = 0; i < buttons.Count; i++) {
			buttons [i].Sound.clip = preset.sounds [i];
		}
	}

}


