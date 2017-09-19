using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for some Stop Button
 * Load Start Scene 
 * 
 * *********************************************/

public class StopButton : MonoBehaviour {

	private LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnMouseDown() {
		levelManager.LoadLevel ("01a Start");
	}
}
