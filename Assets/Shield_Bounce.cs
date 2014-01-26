using UnityEngine;
using System.Collections;

public class Shield_Bounce : MonoBehaviour {
    public float modifier;
    // Use this for initialization
	void Start () {
		modifier = 3f;
	}
	
    void OnCollisionExit(Collision collisionInfo) {
        if (collisionInfo.gameObject.tag.Equals("enemy")) {
			collisionInfo.gameObject.rigidbody.velocity = modifier * collisionInfo.gameObject.rigidbody.velocity;
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
