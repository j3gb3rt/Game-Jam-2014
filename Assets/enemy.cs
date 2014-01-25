using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    public int face;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (face == 0 && this.rigidbody.velocity.x > -5)
        {
            this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x - 1f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
        }
        if (face == 1 && this.rigidbody.velocity.x < 5)
        {
            this.rigidbody.velocity = new Vector3(this.rigidbody.velocity.x + 1f, this.rigidbody.velocity.y, this.rigidbody.velocity.z);
        }
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("leftBound"))
        {
            print("am too far lefts!");
            face = 1;
        }
        if (other.gameObject.name.Equals("rightBound"))
        {
            print("am too far rights!");
            face = 0;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals("enemy"))
        {
            if (face == 0) face = 1;
            else face = 0;
        }
    }
}
