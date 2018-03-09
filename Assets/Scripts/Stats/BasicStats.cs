using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStats {

	private string name;	// Name
	private float speed;	// Speed
	private int actions;	// Actions

	public string Name { get { return name; } }
	public float Speed { get { return speed; } }
	public int Actions { get { return actions; } }

	public BasicStats(string name) {
		this.name = name;
		speed = 3.0f;
		actions = 3;
	}

	public BasicStats(string name, float speed, int actions) {
		this.name = name;
		this.speed = speed;
		this.actions = actions;
	}
}
