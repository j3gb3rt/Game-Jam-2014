using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {
	int health;

	// Use this for initialization
	void Start () {
		health = 3;
	}

	void takeDamage() {
		health -= 1;
		transform.Rotate(new Vector3(0,30,0));
	}

	void takeDamage(int d) {
		health -= d;
	}

	void Update() {
		//Debug Code to test damage. Delete before shipping.
		if (Input.GetKeyDown ("k")) {
				takeDamage ();
		} //end of debug code

		if (health <= 0) {
			Transform.Destroy (gameObject);
		}
	}
}
