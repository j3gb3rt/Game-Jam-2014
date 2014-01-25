using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	private Vector3 initPosition;
	private int firstMovement;
	public float xVelocity;
	public float yVelocity;
	public float xDistance;
	public float yDistance;
	private float xMin;
	private float xMax;
	private float yMin;
	private float yMax;
	
	// Use this for initialization
	void Start () {
		initPosition = transform.position;
		//firstMovement = true;
		if (initPosition.x < initPosition.x + xDistance) {
			xMin = initPosition.x;
			xMax = initPosition.x + xDistance;
		} else {
			xMin = initPosition.x + xDistance;
			xMax = initPosition.x;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position.x += xDistance;


		if (transform.position.x == initPosition.x) {

		}
		else if (transform.position.x == (initPosition.x + xVelocity)) {

		}
	}
}
