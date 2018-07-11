using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotInt : MonoBehaviour {
	// Simple script used for the shot integer, which can easily be changed in each level.
	// Perhaps this should be merged into main.cs?
	public static int remainingShots { get; set; }
	public int shotNumber;
	// Use this for initialization
	void Start () {
		remainingShots = shotNumber;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
