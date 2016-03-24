using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public AudioSource Sound;

	void OnMouseDown()
	{
		AudioClip clip = Sound.clip;
		AudioClip clipClone = (AudioClip)Instantiate (clip);

		EventManager.instance.SoundButtonClicked (clipClone, Sound);
		Sound.PlayOneShot(Sound.clip);
	}
}
