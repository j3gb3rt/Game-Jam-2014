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
        if (Input.GetKey("1") || Input.GetKey(KeyCode.Keypad1))
        {
			this.renderer.material = IceMaterial;
			this.collider.isTrigger = false;
			this.gameObject.name = "Ice";
        }
        else if (Input.GetKey("2") || Input.GetKey(KeyCode.Keypad2))
        {
			this.renderer.material = LavaMaterial;
			this.collider.isTrigger = true;
			this.gameObject.name = "Lava";
        }
        else if (Input.GetKey("3") || Input.GetKey(KeyCode.Keypad3))
        {
			this.renderer.material = WaterMaterial;
			this.collider.isTrigger = true;
			this.gameObject.name = "Water";
		}
	}
}
