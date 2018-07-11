using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPower : MonoBehaviour {
	public int powerLevel = 0;
	public Rigidbody2D rb;
	public TextMesh powerLevelText;
	public int powerBarPosition;
	// Only set in left bar!
	public int remainingShots;
	public Vector2 powerLaunch;


	//0 is left, 1 is right

	// Use this for initialization
	void Start () {
		main.shots = shotInt.remainingShots;

		powerLevelText.text = "0";
		Debug.Log ("Shots: " + main.shots);
	}
	
	// Left Bar
	void OnMouseOver () {
		if (powerBarPosition == 0) {
		powerLaunch = transform.TransformDirection (Vector2.right);
		if (Input.GetMouseButton (0)) {
			powerLevel = powerLevel + 5;
			if (powerLevel >= 200) {
				powerLevel = 200;
			}
			powerLevelText.text = powerLevel.ToString ();
			// Debug.Log (powerLevel);

		}
			launch ();
	}

		// Right Bar
		if (powerBarPosition == 1) {
			powerLaunch = transform.TransformDirection (Vector2.left );
			if (Input.GetMouseButton (0)) {
				powerLevel = powerLevel + 5;
				if (powerLevel >= 200) {
					powerLevel = 200;
				}
				powerLevelText.text = powerLevel.ToString ();
				//Debug.Log (powerLevel);

			}
			launch ();

}
}
			
	void launch () {
		if (Input.GetMouseButtonUp (0) && main.shots > 0) {
			main.shots = main.shots - 1; 
			Debug.Log ("Mouse is Up");
			rb.AddForce (powerLaunch * powerLevel * 500 * Time.deltaTime, 0);
			powerLevel = 0;
			powerLevelText.text = powerLevel.ToString ();
			Debug.Log ("Shots: " + main.shots);

}
	}
}
