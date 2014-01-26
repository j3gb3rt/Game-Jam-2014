using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {
	private int health;
	private int invuln;
    private Vector3 spawnPoint;
    private Quaternion spawnRotation;
    

	// Use this for initialization
	void Start () {
		health = 3;
        spawnPoint = transform.position;
        spawnRotation = transform.rotation;
	}

	void takeDamage() {
		if (invuln < 1) {
			health -= 1;
			invuln = 75;
			//transform.Rotate(new Vector3(0,30,0));
            
		}
	}

	void takeDamage(int d) {
		if (invuln < 1) {
			health -= d;
			invuln = 75;
			//transform.Rotate(new Vector3(0,30,0));
		}
	}

    void respawn()
    {
        this.rigidbody.velocity = new Vector3(0,0,0);
        transform.position = spawnPoint;
        transform.rotation = spawnRotation;
        health = 3;
    }

	void OnTriggerStay(Collider other) {
        if (other.gameObject.name.Equals("Lava")) {
				takeDamage ();
		}
        if (other.gameObject.name.Equals("Checkpoint"))
        {
            spawnPoint = transform.position;
        }
	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.name.Equals("enemy") || collisionInfo.gameObject.name.Equals("Sanic"))
        {
            takeDamage();
        }
        if (collisionInfo.gameObject.name.Equals("Ground_Plate"))
        {
            respawn();

        }
    }

	void Update() {
        healthbard.health = health;
		//Debug Code to test damage. Delete before shipping.
		if (Input.GetKeyDown ("p")) {
			takeDamage ();
		} //end of debug code

		if (invuln > 0) {
			invuln--;
		}

		if (health <= 0) {
            respawn();
            //Transform.Destroy (gameObject);
		}

        if (transform.position.y < -200)
        {
            takeDamage(3);
        }
	}
}
