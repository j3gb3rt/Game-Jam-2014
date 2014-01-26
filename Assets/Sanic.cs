using UnityEngine;
using System.Collections;

public class Sanic : MonoBehaviour {
    public int face = 0;
    public Transform player;
    int rage = 0;
    int element = 1;
    int health = 5;

    public Material ice;
    public Material fire;
    public Material nature;

    public Mesh iceM;
    public Mesh fireM;
    public Mesh natureM;

    MeshFilter mesh;

	// Use this for initialization
	void Start () {
        //ice = Resources.Load<Material>("Materials/IceMon");
        //iceM = Resources.Load<Mesh>("Iceling/pSphere1");

        //fireM = Resources.Load<Mesh>("Emberling/pSphere1");
	}
	
	// Update is called once per frame
	void Update () {
        //check for player;\
        if (element != 3)
        {
            if (face == 0 && player.position.x < this.transform.position.x && player.position.x > this.transform.position.x - 20 || face == 1 && player.position.x > this.transform.position.x && player.position.x < this.transform.position.x + 20)
            {
                rage = 1;
            }
        }
        if (rage == 0)
        {
            if (face == 0 && this.rigidbody.velocity.x > -5)
            {
                this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x - 2f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
            }
            if (face == 1 && this.rigidbody.velocity.x < 5)
            {
                this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x + 2f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
            }
        }
        else
        {
            if (face == 0 && this.rigidbody.velocity.x > -20)
            {
                this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x - 4f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
            }
            if (face == 1 && this.rigidbody.velocity.x < 20)
            {
                this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x + 4f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
            }
        }

        if(health<=0){
            Transform.Destroy(gameObject);
        }



        if (Input.GetKey("1") || Input.GetKey(KeyCode.Keypad1))
        {
            element = 1;
            this.renderer.material = ice;
            GetComponent<MeshFilter>().mesh = iceM;
            
        }
        else if (Input.GetKey("2") || Input.GetKey(KeyCode.Keypad2))
        {
            element = 2;
            this.renderer.material = fire;
            //mesh.mesh = fireM;
            GetComponent<MeshFilter>().mesh = fireM;
        }
        else if (Input.GetKey("3") || Input.GetKey(KeyCode.Keypad3))
        {
            element = 3;
            this.renderer.material = nature;
            GetComponent<MeshFilter>().mesh = natureM;
        }

	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("leftBound"))
        {
            rage = 0;
            face = 1;
        }
        if (other.gameObject.name.Equals("rightBound"))
        {
            rage = 0;
            face = 0;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals("Sanic"))
        {
            if (face == 0) face = 1;
            else face = 0;
        }

        

        if (other.gameObject.tag.Equals("projectile"))
        {
            health--;
            print("HIT SANIC!!");
        }
    }
}
