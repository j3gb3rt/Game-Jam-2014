using UnityEngine;
using System.Collections;

public class CameraBound : MonoBehaviour {

	private Vector3 initPosition;
	// Use this for initialization
	void Start () {
		initPosition = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		//horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		//vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

		Vector3 pos = transform.position;
		//pos.x = Mathf.Clamp(pos.x + horizontal, -7, 7);
		if (pos.y < (initPosition.y + 5)) {
			pos.y = initPosition.y;
		} else {
			pos.y = Mathf.Clamp (pos.y, initPosition.y, initPosition.y + 5);
		}
		transform.position = pos;
	}
}
