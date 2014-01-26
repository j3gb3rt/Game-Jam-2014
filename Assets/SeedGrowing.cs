using UnityEngine;
using System.Collections;

public class SeedGrowing : MonoBehaviour {
	int timer;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = new Vector3 (0, 12, 0);
		timer = 30;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer --;
		}
		else {
			rigidbody.constraints = RigidbodyConstraints.FreezeAll;
			rigidbody.velocity = new Vector3(0,0,0);
		}

		if(Input.GetKeyDown ("2")) {
			Transform.Destroy (gameObject);
		}
	}
}
