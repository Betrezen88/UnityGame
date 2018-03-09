using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill {

	private StatsEnums.Attribute attribute;
	private StatsEnums.Skill type;
	private int value;

	public StatsEnums.Attribute Attribute { get { return attribute; } }
	public StatsEnums.Skill Type { get { return type; } }
	public int Value { get { return value; } }

	public Skill(int value, StatsEnums.Skill type, StatsEnums.Attribute attribute) {
		this.value = value;
		this.type = type;
		this.attribute = attribute;
	}

	public void IncreaseBy(int value) {
		this.value += value;
	}
}
