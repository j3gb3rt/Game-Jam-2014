﻿using UnityEngine;
using System.Collections;

public class SeedBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("2")) {
			Transform.Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag.Equals("Ground")) {
			GameObject tree = Resources.Load<GameObject>("GrownTree2");
			Instantiate(tree, transform.position, transform.localRotation);
		}
		Transform.Destroy (gameObject);
		
	}

	void OnBecameInvisible() {
		Transform.Destroy (gameObject);
	}
}
