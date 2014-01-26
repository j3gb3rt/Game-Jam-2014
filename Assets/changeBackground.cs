using UnityEngine;
using System.Collections;

public class changeBackground  : MonoBehaviour {
	private Material NatureBackground, FrostBackground, FireBackground;

	void Start () {
		FireBackground = Resources.Load<Material>("Materials/bg_fire");
        FrostBackground = Resources.Load<Material>("Materials/bg_ice");
        NatureBackground = Resources.Load<Material>("Materials/bg_nature");

        this.renderer.material = FrostBackground;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("1") || Input.GetKey(KeyCode.Keypad1)) {
			this.renderer.material = FrostBackground;
		} else if (Input.GetKey ("2") || Input.GetKey(KeyCode.Keypad2)) {
			this.renderer.material = FireBackground;
		} else if (Input.GetKey ("3") || Input.GetKey(KeyCode.Keypad3)) {
			this.renderer.material = NatureBackground;
		}

	}
}
