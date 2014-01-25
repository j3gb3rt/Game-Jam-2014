using UnityEngine;
using System.Collections;

public class changeLand : MonoBehaviour {
	private Material NatureMaterial, FrostMaterial, FireMaterial;

	void Start () {
		FireMaterial = Resources.Load<Material>("Fire_Color");
		FrostMaterial = Resources.Load<Material>("Frost_Color");
		NatureMaterial = Resources.Load<Material>("Nature_Color");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("1") || Input.GetKey(KeyCode.Keypad1)) {
			this.renderer.material = FrostMaterial;
		} else if (Input.GetKey ("2") || Input.GetKey(KeyCode.Keypad2)) {
			this.renderer.material = FireMaterial;
		} else if (Input.GetKey ("3") || Input.GetKey(KeyCode.Keypad3)) {
			this.renderer.material = NatureMaterial;
		}

	}
}
