using UnityEngine;
using System.Collections;

public class changeLand : MonoBehaviour {
	private Material NatureMaterial, IceMaterial, FireMaterial;

	void Start () {
		FireMaterial = Resources.Load<Material>("Fire_Color");
		IceMaterial = Resources.Load<Material>("Ice_Color");
		NatureMaterial = Resources.Load<Material>("Nature_Color");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("1")) {
			this.renderer.material.color = Color.blue;
		} else if (Input.GetKey ("2")) {
			this.renderer.material.color = Color.red;
		} else if (Input.GetKey ("3")) {
			this.renderer.material.color = Color.green;
		}

	}
}
