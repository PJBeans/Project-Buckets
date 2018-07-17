using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour {
	//This script is used to reset the current scene. It should be disabled prior to a public release on a store (E.g.: Google Play).
	//The sprite also won't be used. Text is baked in; Buckets uses Text Meshes for buttons. "Reset.png" was reused from Stride Jump, and will likely be removed before release.
	public int enabled = 0;

	void OnMouseDown () {
		if (enabled == 1) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		if (enabled == 0) {
			Debug.Log ("\"Reset\" is disabled. Please set \"enabled\" to \"1.\"");
}
}
}
