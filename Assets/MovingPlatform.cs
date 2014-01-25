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

        xVelocity = xVelocity / 10;
        yVelocity = yVelocity / 10;

		if (initPosition.x < initPosition.x + xDistance) {
			xMin = initPosition.x;
			xMax = initPosition.x + xDistance;
		} else {
			xMin = initPosition.x + xDistance;
			xMax = initPosition.x;
		}

        print("xmin" + xMin);
        print("xmax" + xMax);

        if (initPosition.y < initPosition.y + yDistance)
        {
            yMin = initPosition.y;
            yMax = initPosition.y + yDistance;
        }
        else
        {
            yMin = initPosition.y + yDistance;
            yMax = initPosition.y;
        }

        print("ymin" + yMin);
        print("ymax" + yMax);

	}
	
	// Update is called once per frame
	void Update () {
        float updatedX;
        float updatedY;
        
        updatedX = transform.position.x + xVelocity;
        updatedY = transform.position.y + yVelocity;

        transform.position = new Vector3(updatedX, updatedY, transform.position.z);

		if ((transform.position.x < xMin) || (transform.position.x > xMax )) {
            xVelocity = -1 * xVelocity;
		}
        if ((transform.position.y < yMin) || (transform.position.y > yMax))
        {
            yVelocity = -1 * yVelocity;

		}
	}
}
