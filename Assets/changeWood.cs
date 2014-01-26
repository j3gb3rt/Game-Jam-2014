using UnityEngine;
using System.Collections;

public class changeWood : MonoBehaviour {
	Vector3 size, startLocation, endLocation;
	// Use this for initialization
	void Start () {
		size = transform.localScale;
		startLocation = transform.localPosition;
		endLocation = transform.localPosition;
		endLocation.y = endLocation.y - (endLocation.y / 2) - 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("1") || Input.GetKey(KeyCode.Keypad1)) {
			//Ice doesn't change the wood.
		} else if (Input.GetKey ("2") || Input.GetKey(KeyCode.Keypad2)) {
			transform.localScale = new Vector3(0,0,0);
			transform.localPosition = endLocation;
		} else if (Input.GetKey ("3") || Input.GetKey(KeyCode.Keypad3)) {
			transform.localScale = size;
			transform.localPosition = startLocation;
		}
	}
}
