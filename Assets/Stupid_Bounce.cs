using UnityEngine;
using System.Collections;

public class Stupid_Bounce : MonoBehaviour {

    public float modifier;
    // Use this for initialization
	void Start () {
	
	}
	
    void OnCollisionExit(Collision collisionInfo) {
        if (collisionInfo.gameObject.name.Equals("enemy")) {
            this.rigidbody.velocity = modifier * this.rigidbody.velocity;
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
