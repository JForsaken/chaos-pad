using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public AudioSource Sound;

	void OnMouseDown()
	{
		Sound.PlayOneShot(Sound.clip);
	}
}
