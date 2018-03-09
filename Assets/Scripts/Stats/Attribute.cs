using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute {

	private StatsEnums.Attribute attribute;
	private StatsEnums.AttrType type;
	private Skills skills = new Skills();

	public StatsEnums.Attribute Attr { get { return attribute; } }
	public StatsEnums.AttrType Type { get { return type; } }
	public Skills Skills { get { return skills; } }

	public Attribute(StatsEnums.Attribute attribute, StatsEnums.AttrType type) {
		this.attribute = attribute;
		this.type = type;
	}
}
