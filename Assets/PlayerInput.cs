using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	int jump;
	public GameObject fire, seed, shield;
	private float speed;
	private int facing, world;

	// Use this for initialization
	void Start () {
		jump = 0;
		speed = 20f;
		fire = Resources.Load<GameObject>("fireball");
		seed = Resources.Load<GameObject> ("Seed");
		facing = 1;
		world = 1;
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
		if (Input.GetKeyDown ("k") && jump > 0){	// recommended gravity is Y=-40;
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, 25, this.rigidbody.velocity.z);
		}

		if (Input.GetKeyDown ("1")) {
			world = 1;
		}
		if (Input.GetKeyDown ("2")) {
			world = 2;
		}
		if (Input.GetKeyDown ("3")) {
			world = 3;
		}


		if (Input.GetKeyDown ("j")){
			if(world == 1) {

			}
			if(world == 2) {
				shootFireball();
			}
			else throwSeed();
		}

	}

	void shootFireball(){
			if (facing == 0) {
				GameObject thisBoom = (GameObject)Instantiate (fire, transform.position - new Vector3(2f,0f,0f), transform.localRotation);
				thisBoom.transform.Rotate (0,90,0);
				thisBoom.rigidbody.velocity = new Vector3(-speed, 0, 0);
			} else {
				GameObject thisBoom = (GameObject)Instantiate (fire, transform.position + new Vector3(2f,0f,0f), transform.localRotation);
				thisBoom.transform.Rotate (0,-90,0);
				thisBoom.rigidbody.velocity = new Vector3(speed, 0, 0);
			}
		}

	void throwSeed(){
			if (facing == 0) {
				GameObject thisSeed = (GameObject)Instantiate (seed, transform.position - new Vector3(2f,0f,0f), transform.localRotation);
				thisSeed.rigidbody.velocity = new Vector3(-speed, 0, 0);
			} else {
				GameObject thisSeed = (GameObject)Instantiate (seed, transform.position + new Vector3(2f,0f,0f), transform.localRotation);
				thisSeed.rigidbody.velocity = new Vector3(speed, 0, 0);
			}
		}

	void OnCollisionEnter(){
		jump++;
	}

	void OnCollisionExit(){
		jump--;
	}
}