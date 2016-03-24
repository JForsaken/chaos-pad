using UnityEngine;
using System.Collections.Generic; 

public class EventManager : MonoBehaviour {

	private bool isRecording;
	private bool isPlaying;
	private int currentTime = 0;

	private List<TimedSound> timedSounds = new List<TimedSound> ();

	public static EventManager instance = null; 

	private EventManager() {}

	void Awake()
	{
		if (instance == null) {
			instance = new EventManager();
		}
	}
		

	public void SoundButtonClicked(AudioClip sound, AudioSource source) {
		if (isRecording) {
			timedSounds.Add(new TimedSound(sound, source, currentTime));
		}
	}

	public void ToggleRecord() {
		if (!EventManager.instance.isPlaying) {
			EventManager.instance.isRecording = !EventManager.instance.isRecording;

			if (EventManager.instance.isRecording) {
				EventManager.instance.currentTime = 0;
			}
		}
	}

	public void TogglePlayLastRecord() {
		if (!EventManager.instance.isRecording) {
			EventManager.instance.isPlaying = !EventManager.instance.isPlaying;

			if (EventManager.instance.isPlaying) {
				EventManager.instance.currentTime = 0;
			}
		}
		
	}

	void FixedUpdate() {
		if (EventManager.instance.isRecording) {
			EventManager.instance.currentTime++;
		}

		if (EventManager.instance.isPlaying) {
			
			foreach (TimedSound item in EventManager.instance.timedSounds) {
				if (item.startTime == EventManager.instance.currentTime) {
					item.source.PlayOneShot(item.clip);
					EventManager.instance.timedSounds.Remove (item);

					if (EventManager.instance.timedSounds.Count == 0) {
						EventManager.instance.isPlaying = false;
					}
					break;
				}
			}
			EventManager.instance.currentTime++;
		}
	}
}

public class TimedSound {
	public AudioClip clip;
	public float startTime;
	public AudioSource source;

	public TimedSound(AudioClip clipToStart, AudioSource soundSource, float time) {
		clip = clipToStart;
		source = soundSource;
		startTime = time;
	}
}
