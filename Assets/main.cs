using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {
	public Rigidbody2D rb;
	public float zapFloat = 50;
	public static int shots { get;	set; }
	public Text deadText;


	// Use this for initialization
	void Start () {
		deadText.text = "";
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
		// bucket is the end goal.
		if (col.gameObject.tag == "bucket") {
			Debug.Log ("bucket");

		}

		// zap sends the ball down.
		if (col.gameObject.tag == "zap") {
			Debug.Log ("zap");
			rb.AddForce (new Vector2 (0, -120000 * Time.deltaTime));

	}
		if (col.gameObject.tag == "floor") {
			Debug.Log ("floor");
			if (shots == 0) {
				deadText.text = "Game Over!";
			}

}
}
}