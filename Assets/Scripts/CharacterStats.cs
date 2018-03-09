using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

	private BasicStats basicStats;
	private Stats stats;

	// Use this for initialization
	void Start () {
		basicStats = new BasicStats ("John Doe");
		stats = new Stats ();

		Debug.Log ("Name: " + basicStats.Name);
		Debug.Log ("Speed: " + basicStats.Speed);
		Debug.Log ("Actions: " + basicStats.Actions);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
