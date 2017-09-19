using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for destroying object which 
 * collides to shredder. (Objects that goes out of screen
 *
 * 
 * *********************************************/

public class Shreddder : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		Destroy (collider.gameObject);	
	}
	
}
