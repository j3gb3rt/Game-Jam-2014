using UnityEngine;
using System.Collections;

public class changeLand : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("1")) {
			this.renderer.material.color = Color.blue;
		} else if (Input.GetKey ("2")) {
			this.renderer.material.color = Color.red;
		} else if (Input.GetKey ("3")) {
			this.renderer.material.color = Color.green;
		}

	}
}
