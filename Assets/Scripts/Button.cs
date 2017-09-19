using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/***************************************************
 * Class responsible for some Buttons
 *
 * 
 * *********************************************/


public class Button : MonoBehaviour {
    // only one defender selected
    public GameObject defenderPrefab;
	public static GameObject selectedDefender;
		
	private Button[] buttonArray;
	private Text costText;
	
	// Use this for initialization
	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button>();
		
		costText = GetComponentInChildren<Text>();
		if (!costText) {Debug.LogWarning (name + " has no cost ");}
		
		costText.text = defenderPrefab.GetComponent<Defender>().starCost.ToString();
	}
	
	void OnMouseDown () {
        //  Debug.Log("Button press" + name);
        foreach (Button thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
		
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defenderPrefab;
        //print(selectedDefender);
    }
}
