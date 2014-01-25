using UnityEngine;
using System.Collections;

public class changeWater : MonoBehaviour {
	private Material WaterMaterial, IceMaterial, LavaMaterial;
	
	void Start () {
		LavaMaterial = Resources.Load<Material>("Lava_Color");
		IceMaterial = Resources.Load<Material>("Ice_Color");
		WaterMaterial = Resources.Load<Material>("Water_Color");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("1")) {
			this.renderer.material = IceMaterial;
			this.collider.isTrigger = false;
		} else if (Input.GetKey ("2")) {
			this.renderer.material = LavaMaterial;
			this.collider.isTrigger = true;
		} else if (Input.GetKey ("3")) {
			this.renderer.material = WaterMaterial;
			this.collider.isTrigger = true;
		}
	}
}
