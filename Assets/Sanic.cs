using UnityEngine;
using System.Collections;

public class Sanic : MonoBehaviour {
    int face = 0;
    public Transform player;
    int rage = 1;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //check for player;
        if (face == 0 && player.position.x < this.transform.position.x && player.position.x > this.transform.position.x - 20 || face == 1 && player.position.x > this.transform.position.x && player.position.x < this.transform.position.x + 20)
        {
            rage = 1;
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
}
