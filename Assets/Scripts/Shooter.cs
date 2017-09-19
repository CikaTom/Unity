using UnityEngine;
using System.Collections;
/***************************************************
 * Class responsible for some Shooter objects
 * Responsible for actions of shooter objects
 * How they react with Attacker in front
 * *********************************************/

public class Shooter : MonoBehaviour {

	public GameObject projectile, gun;
	
	private GameObject projectileParent;
	private Animator animator;
	private Spawner myLaneSpawner;
	
	void Start () {
        // finding an animator
        animator = GameObject.FindObjectOfType<Animator>();


        // if there is no result of this type object, then create one
        // creates Projectiles type of objects, for example weapons and axes
        projectileParent = GameObject.Find ("Projectiles");
		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}
		
		SetMyLaneSpawner();
        //   print(myLaneSpawner);
    }

    void Update () {
		if (IsAttackerAheadInLane()) {
			animator.SetBool ("isAttacking", true);
		} else {
			animator.SetBool ("isAttacking", false);
		}
	}

    // looks through all spawners and set myLanerSpawner if found
    void SetMyLaneSpawner () {
		Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();
		
		foreach (Spawner spawner in spawnerArray) {
			if (spawner.transform.position.y == transform.position.y) {
				myLaneSpawner = spawner;
				return;
			}
		}
        // if we dont have spawner 
        Debug.LogError (name + " can't find spawner in lane");
	}

    // checks if there is an attacker in front lane
    bool IsAttackerAheadInLane() {
        // Exits if no attackers in lane
        if (myLaneSpawner.transform.childCount <= 0) {
			return false;
		}

        // if there are attackers
        foreach (Transform attacker in myLaneSpawner.transform) {
            // if child of attakers
            if (attacker.transform.position.x > transform.position.x) {
				return true;
			}
		}

        // Attackers in lane, but they are behind
        return false;
	}

    // attackers fires a projectile
    private void Fire () {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gun.transform.position;
	}
}
