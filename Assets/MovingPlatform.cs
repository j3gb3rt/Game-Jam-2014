using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	private Vector3 initPosition;
	public float X_Direction;
	public float Y_Direction;
	public float X_Distance;
	public float Y_Distance;
	// Use this for initialization
	void Start () {
		initPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
