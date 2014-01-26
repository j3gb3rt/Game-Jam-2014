using UnityEngine;
using System.Collections;

public class FireballBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter() {
		GameObject exploder = Resources.Load<GameObject>("Explosion");
		Instantiate(exploder, transform.position, transform.localRotation);
		Transform.Destroy (gameObject);
	}

	void OnBecameInvisible() {
		Transform.Destroy (gameObject);
	}
}
