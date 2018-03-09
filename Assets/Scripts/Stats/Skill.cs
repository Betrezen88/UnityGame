using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill {

	private StatsEnums.Attribute attribute;
	private int value;

	public StatsEnums.Attribute Attribute { get { return attribute; } }
	public int Value { get { return value; } }

	public Skill(int value, StatsEnums.Attribute attribute) {
		this.value = value;
		this.attribute = attribute;
	}

	public void IncreaseBy(int value) {
		this.value += value;
	}

	public void DecreaseBy(int value) {
		this.value -= value;
	}
}
