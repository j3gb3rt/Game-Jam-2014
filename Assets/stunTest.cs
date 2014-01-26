using UnityEngine;
using System.Collections;

public class stunTest : MonoBehaviour {
	public GameObject boom;
	private float speed;

	void Start () {
		speed = 10f;
		boom = Resources.Load<GameObject>("fireball");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("n")) {
			shootFireball();
		}
	}

	void shootFireball(){
			GameObject thisBoom = (GameObject)Instantiate (boom, transform.position, transform.localRotation);
	}
}
