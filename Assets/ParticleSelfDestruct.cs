using UnityEngine;
using System.Collections;

public class ParticleSelfDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.particleSystem.isStopped)
			Transform.Destroy (gameObject);
	}
}
