using UnityEngine;
using UnityEngine.UI;
using System.Collections;
/***************************************************
 * Class responsible for some Options Scene
 * Responsible for Options scene 
 * Saves volume and difficult level on leaving scene and game
 * 
 * *********************************************/

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider, diffSlider;
	public LevelManager levelManager;
	
	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.getMasterVolume ();
		diffSlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume (volumeSlider.value);
	}
	
	public void SaveAndExit () {
		PlayerPrefsManager.setMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (diffSlider.value);
		levelManager.LoadLevel ("01a Start");
	}
	
	public void SetDefaults () {
		volumeSlider.value = 0.8f;
		diffSlider.value = 2f;
	}
}
