using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for some Music
 *Responsible for loading music and maintaining 
 * in different scenes and also
 *  for volume in the options scene
 * 
 * *********************************************/

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	void Awake() {
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destory on load: " + name);
	}
	
	void Start () {
		audioSource = GetComponent<AudioSource>();
		audioSource.volume = PlayerPrefsManager.getMasterVolume();
	}
	
	void OnLevelWasLoaded (int level) {
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log ("Playing clip: " + thisLevelMusic);


        // if there is some music attached
        if (thisLevelMusic) {
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
	
	public void SetVolume (float volume) {
		audioSource.volume = volume;
	}
}
