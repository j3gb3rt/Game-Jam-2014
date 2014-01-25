using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	int jump;
	// Use this for initialization
	void Start () {
		jump = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//check for inputs

		if (Input.GetKey ("a") && this.rigidbody.velocity.x > -15){
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x - 1.5f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
		}
		if (Input.GetKey ("d") && this.rigidbody.velocity.x < 15){
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x + 1.5f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
		}
		if (Input.GetKeyDown ("space") && jump == 1){	// recommended gravity is Y=-40;
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, 20, this.rigidbody.velocity.z);
		}

	}

	void OnCollisionEnter(){
		jump++;
	}

	void OnCollisionExit(){
		jump--;
	}
}
