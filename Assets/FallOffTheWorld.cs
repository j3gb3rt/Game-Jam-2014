using UnityEngine;
using System.Collections;

public class FallOffTheWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.name.Equals("Ground_Plate"))
        {
            transform.position = new Vector3(0, 5, 0);
        }
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
