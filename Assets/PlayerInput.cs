using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	int jump;
	public GameObject fire;
	private float speed;
	private int facing;

	// Use this for initialization
	void Start () {
		jump = 0;
		speed = 20f;
		fire = Resources.Load<GameObject>("fireball");
		facing = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//check for inputs

		if (Input.GetKey ("a") && this.rigidbody.velocity.x > -15){
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x - 1.5f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
			facing = 0;
		}
		if (Input.GetKey ("d") && this.rigidbody.velocity.x < 15){
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x + 1.5f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
			facing = 1;
		}
		if (Input.GetKeyDown ("space") && jump > 0){	// recommended gravity is Y=-40;
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, 25, this.rigidbody.velocity.z);
		}
		if (Input.GetKeyDown ("j")){
			shootFireball();
		}

	}

	void shootFireball(){
		if (facing == 0) {
			GameObject thisBoom = (GameObject)Instantiate (fire, transform.position - new Vector3(1.5f,0f,0f), transform.localRotation);
			thisBoom.transform.Rotate (0,90,0);
			thisBoom.rigidbody.velocity = new Vector3(-speed, 0, 0);
		} else {
			GameObject thisBoom = (GameObject)Instantiate (fire, transform.position + new Vector3(1.5f,0f,0f), transform.localRotation);
			thisBoom.transform.Rotate (0,-90,0);
			thisBoom.rigidbody.velocity = new Vector3(speed, 0, 0);
		}
	}

	void OnCollisionEnter(){
		jump++;
	}

	void OnCollisionExit(){
		jump--;
	}
}