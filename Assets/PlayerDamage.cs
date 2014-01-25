using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {
	int health;
	int invuln;

	// Use this for initialization
	void Start () {
		health = 3;
	}

	void takeDamage() {
		if (invuln < 1) {
			health -= 1;
			invuln = 75;
			transform.Rotate(new Vector3(0,30,0));
		}
	}

	void takeDamage(int d) {
		if (invuln < 1) {
			health -= d;
			invuln = 100;
			transform.Rotate(new Vector3(0,30,0));
		}
	}

	void OnTriggerStay(Collider other) {
		takeDamage ();
	}

	void Update() {
		//Debug Code to test damage. Delete before shipping.
		if (Input.GetKeyDown ("k")) {
			takeDamage ();
		} //end of debug code

		if (invuln > 0) {
			invuln--;
		}

		if (health <= 0) {
			Transform.Destroy (gameObject);
		}
	}
}
