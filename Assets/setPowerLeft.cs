using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is deprecated. It will be removed soon. This was used along with setPower.cs for the second Power Bar, until I unified the script.
public class setPowerLeft : MonoBehaviour {
	public int powerLevel = 0;
	public Rigidbody2D rb;
	public TextMesh powerLevelText;

	// Use this for initialization
	void Start () {
		powerLevelText.text = "0";
	}
	
	// Update is called once per frame
	void OnMouseOver () {
		
		Vector2 powerLaunch = transform.TransformDirection (Vector2.left );
		if (Input.GetMouseButton (0)) {
			powerLevel = powerLevel + 5;
			if (powerLevel >= 200) {
				powerLevel = 200;
			}
			powerLevelText.text = powerLevel.ToString ();
			Debug.Log (powerLevel);

		}
		if (Input.GetMouseButtonUp (0)) {
			
			Debug.Log ("Mouse is Up");
			rb.AddForce (powerLaunch * powerLevel * 500 * Time.deltaTime, 0);
			powerLevel = 0;
			powerLevelText.text = powerLevel.ToString ();

		}
	}

}
