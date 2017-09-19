using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for Health
 * 
 * Responsible for health bar and dies
 * 
 * 
 * *********************************************/
public class Health : MonoBehaviour {
	
	public float health = 100f;
	
	public void DealDamage (float damage) {
		health -= damage;
		if (health < 0) {
			// Optionally trigger animation
			DestoryObject ();
		}
	}
	
	public void DestoryObject () {
		Destroy (gameObject);
	}
	
}
