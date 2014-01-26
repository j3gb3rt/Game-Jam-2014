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
    private bool lastVelFlipLeft;
    private bool lastVelFlipDown;

	// Use this for initialization
	void Start () {
		initPosition = transform.position;

        if (xVelocity > 0)
        {
            lastVelFlipLeft = true;
        }
        else
        {
            lastVelFlipLeft = false;
        }

        if (yVelocity > 0)
        {
            lastVelFlipDown = true;
        }
        else
        {
            lastVelFlipDown = false;
        }


        //xVelocity = xVelocity;
        //yVelocity = yVelocity;

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
        //float updatedX;
        //float updatedY;
        
        //updatedX = transform.position.x + xVelocity;
        //updatedY = transform.position.y + yVelocity;

        this.rigidbody.velocity = new Vector3(xVelocity, yVelocity, 0f);

        //transform.position = new Vector3(updatedX, updatedY, transform.position.z);

		if ((transform.position.x < xMin) &&  !lastVelFlipLeft) {
            xVelocity = -1 * xVelocity;
            lastVelFlipLeft = true;
        }
        
        if ((transform.position.x > xMax) &&  lastVelFlipLeft) {
            xVelocity = -1 * xVelocity;
            lastVelFlipLeft = false;
        }

        if ((transform.position.y < yMin) && !lastVelFlipDown) {
            yVelocity = -1 * yVelocity;
            lastVelFlipDown = true;
        }

        if ((transform.position.x > xMax) && lastVelFlipDown) {
            yVelocity = -1 * yVelocity;
            lastVelFlipDown = false;
        }
	}
}
