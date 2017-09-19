using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for some Stone objects
 * For being a tag and triggers of being attacked
 * 
 * *********************************************/

public class Stone : MonoBehaviour {
	
	private Animator animator;
	
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	void Update () {
		
	}
	
	void OnTriggerStay2D (Collider2D collider) {
		Attacker attacker = collider.gameObject.GetComponent<Attacker>();
		
		if (attacker) {
			animator.SetTrigger ("underAttack trigger");
		}
	}
}
