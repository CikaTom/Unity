using UnityEngine;
using System.Collections;

/***************************************************
 * Class responsible for some Lizard objects
 * Responsible actions/animations on colliders
 * 
 * *********************************************/


// lizard requires to have Attacker component
[RequireComponent (typeof (Attacker))]
public class Lizard : MonoBehaviour {
	
	private Animator anim;
	private Attacker attacker;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		GameObject obj = collider.gameObject;

        // if not colliding
        if (!obj.GetComponent<Defender>()) {
			return;
		}
		
		anim.SetBool ("isAttacking", true);
		attacker.Attack (obj);

        // testing if attacker colides with defende
        Debug.Log("lizard colided with" + collider);
    }
}
