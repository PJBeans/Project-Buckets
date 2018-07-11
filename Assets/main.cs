using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {
	public Rigidbody2D rb;
	public float zapFloat = 50;
	public static int shots { get;	set; }


	// Use this for initialization
	void Start () {
		Debug.Log ("Main: shots: " + shots);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 pRight = transform.TransformDirection (Vector2.right);
		if (Input.GetKey ("d")) {
			rb.AddForce (pRight * 500 * Time.deltaTime, 0);
		}
			if(Input.GetKey("a")) {
			rb.AddForce (-pRight * 500 * Time.deltaTime, 0);
	}

}

	void OnCollisionEnter2D (Collision2D col) {
		Vector2 zapForce = transform.TransformDirection (Vector2.down);
		if (col.gameObject.tag == "bucket") {
			Debug.Log ("bucket");

		}
		if (col.gameObject.tag == "zap") {
			Debug.Log ("zap");
			transform. position = new Vector2 (0, -2);

	}
}
}