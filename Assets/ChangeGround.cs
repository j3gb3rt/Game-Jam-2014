using UnityEngine;
using System.Collections;
using Textures;

public class ChangeGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void worldChange(int world) {
			
		}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown('1')) {
			this.renderer.material = Fire_Color;
			}
		else if(Input.GetKeyDown('2')) {
			this.renderer.material = Water_Color;
		}
		else if(Input.GetKeyDown('2')) {
			this.renderer.material = Nature_Color;
		}
}
