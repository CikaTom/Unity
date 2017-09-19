using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for some Loose
 *  Loads the Lose level
 * 
 * *********************************************/

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnTriggerEnter2D () {
		levelManager.LoadLevel ("03b Lose");
	}
}
