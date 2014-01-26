using UnityEngine;
using System.Collections;

public class healthbard : MonoBehaviour {
    public static int health = 3;

    Texture h0;
    Texture h1;
    Texture h2;
    Texture h3;

	// Use this for initialization
	void Start () {
        h0 = Resources.Load<Texture>("HealthBar/hbar0");
        h1 = Resources.Load<Texture>("HealthBar/hbar1");
        h2 = Resources.Load<Texture>("HealthBar/hbar2");
        h3 = Resources.Load<Texture>("HealthBar/hbar3");
	}
	
	// Update is called once per frame
	void Update () {
        if (health == 3)
        {
            this.guiTexture.texture = h3;
        }
        else if (health == 2)
        {
            this.guiTexture.texture = h2;
        }
        else if (health == 1)
        {
            this.guiTexture.texture = h1;
        }
        else
        {
            this.guiTexture.texture = h0;
        }
	}
}
