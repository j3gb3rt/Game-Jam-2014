using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	int jump;
	public GameObject fire, seed, shield, iceThrow;
	private float speed;
	private int facing, world;
	private int cooldown;
	private bool shielded;
	private GameObject heldShield;

    private float distToGround;
    private Animator anim;
    private Vector3 previousCameraLocation;
    private Quaternion previousCameraRotation;

	// Use this for initialization
	void Start () {
		jump = 0;
		speed = 20f;
		fire = Resources.Load<GameObject>("fireball");
		seed = Resources.Load<GameObject> ("Seed");
		shield = Resources.Load<GameObject> ("Shield");
		iceThrow = Resources.Load<GameObject> ("Ice_Particles");
		facing = 1;
		world = 1;
		cooldown = 0;

        distToGround = collider.bounds.extents.y;
        anim = this.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		//check for inputs
		cooldown --;

		if (Input.GetKey ("a") && this.rigidbody.velocity.x > -15){
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x - 1.5f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
            if (facing != 0)
            {
                facing = 0;
                previousCameraLocation = this.GetComponentInChildren<Camera>().transform.position;
                previousCameraRotation = this.GetComponentInChildren<Camera>().transform.rotation;
                this.transform.Rotate(new Vector3(0, 180, 0));
               
                //this.GetComponentInChildren<Camera>().transform.Rotate(new Vector3(0, -180, 0));
                this.GetComponentInChildren<Camera>().transform.position = previousCameraLocation;
                this.GetComponentInChildren<Camera>().transform.rotation = previousCameraRotation;
            }
		}
		if (Input.GetKey ("d") && this.rigidbody.velocity.x < 15){
			this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x + 1.5f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
            if (facing != 1)
            {
                facing = 1;
                previousCameraLocation = this.GetComponentInChildren<Camera>().transform.position;
                previousCameraRotation = this.GetComponentInChildren<Camera>().transform.rotation;
                this.transform.Rotate(new Vector3(0, 180, 0));

                //this.GetComponentInChildren<Camera>().transform.Rotate(new Vector3(0, -180, 0));
                this.GetComponentInChildren<Camera>().transform.position = previousCameraLocation;
                this.GetComponentInChildren<Camera>().transform.rotation = previousCameraRotation;
            }
		}
		//if (Input.GetKeyDown ("k") && jump > 0){	// recommended gravity is Y=-40;
			//this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, 25, this.rigidbody.velocity.z);
		//}

        if (Input.GetKeyDown("1") || Input.GetKeyDown(KeyCode.Keypad1))
        {
			world = 1;
		}
        if (Input.GetKeyDown("2") || Input.GetKeyDown(KeyCode.Keypad2))
        {
			world = 2;
		}
		if (Input.GetKeyDown ("3") || Input.GetKeyDown(KeyCode.Keypad3)) {
			world = 3;
		}

        if (Input.GetKeyDown ("j") && world == 1) {
            heldShield = (GameObject)Instantiate (shield, transform.position + new Vector3(0, 90, 0), transform.localRotation);
            heldShield.transform.Rotate(0, 0, 90);
			iceThrow = (GameObject)Instantiate (iceThrow, transform.position + new Vector3(0, 90, 0), transform.localRotation);
			iceThrow.transform.Rotate(0, 0, 90);
            shielded = true;
        }

		if (Input.GetKey ("j")){
			if(cooldown < 1) {
				if(world == 1) {
					if(shielded) {
						if(facing == 0) {
							heldShield.transform.position = this.transform.position - new Vector3(3f,-2.5f,0f);
							iceThrow.transform.position = this.transform.position - new Vector3(0f,-2.5f,0f);
						}
						else {
							iceThrow.transform.position = this.transform.position + new Vector3(3f,2.5f,0f);
						}
					}
				}
				if(world == 2) {
					shootFireball();
					cooldown = 30;
				}
				else if(world == 3) {
					throwSeed();
					cooldown = 60;
				}
			}
		}
		if(Input.GetKeyUp ("j")) {
			Transform.Destroy(heldShield);
			Transform.Destroy(iceThrow);
			shielded = false;
		}

        print("moving " + IsMoving() + ", grounded " + IsGrounded() + ", dist from ground " + (distToGround + 0.1f));
        anim.SetBool("Moving", IsMoving());
        anim.SetBool("Grounded", IsGrounded());

	}

    void FixedUpdate()
    {
        if (Input.GetKeyDown("k") && IsGrounded())
        {
            this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x, 30, this.rigidbody.velocity.z);
        }

    }

	void shootFireball(){
			if (facing == 0) {
				GameObject thisBoom = (GameObject)Instantiate (fire, transform.position - new Vector3(3f,-2.5f,0f), transform.localRotation);
				thisBoom.rigidbody.velocity = new Vector3(-speed, 0, 0);
				thisBoom.transform.Rotate (0,180,0);
			} else {
			GameObject thisBoom = (GameObject)Instantiate (fire, transform.position + new Vector3(3f,2.5f,0f), transform.localRotation);
				thisBoom.transform.Rotate (0,180,0);
				thisBoom.rigidbody.velocity = new Vector3(speed, 0, 0);
			}
		}

	void throwSeed(){
			if (facing == 0) {
			GameObject thisSeed = (GameObject)Instantiate (seed, transform.position - new Vector3(3f,-2.5f,0f), transform.localRotation);
				thisSeed.rigidbody.velocity = new Vector3(-speed, 0, 0);
                thisSeed.transform.Rotate(0, 90, 0);
			} else {
			GameObject thisSeed = (GameObject)Instantiate (seed, transform.position + new Vector3(3f,2.5f,0f), transform.localRotation);
                thisSeed.transform.Rotate(0, -90, 0);
				thisSeed.rigidbody.velocity = new Vector3(speed, 0, 0);
			}
		}

	void OnCollisionEnter(){
		jump++;
	}

	void OnCollisionExit(){
		jump--;
	}

    bool IsMoving()
    {
        return (Mathf.Abs(this.rigidbody.velocity.magnitude) > .5);
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, (distToGround + 0.1f));
    }

}