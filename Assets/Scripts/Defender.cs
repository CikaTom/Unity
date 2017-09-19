using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for being a tag and adding star points to start Display
 *
 * 
 * *********************************************/

public class Defender : MonoBehaviour {
	
	public int starCost = 100;
	
	private StarDisplay starDisplay;

	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}

    // used only for being a tag
    public void AddStars (int amount) {
		starDisplay.AddStars (amount);
	}
}
