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

		FillSkillList ();
	}

	private void FillSkillList() {
		int value = GetValue ();
		foreach (Skill skill in skills.GetByAttribute(attribute))
			skill.IncreaseBy (value);
	}

	private int GetValue() {
		if (StatsEnums.AttrType.Good == type)
			return 15;
		else if (StatsEnums.AttrType.Normal == type)
			return 10;
		else if (StatsEnums.AttrType.Bad == type)
			return 5;
		else
			return 0;	// Default, we never get here, this is only for no error purpose.
	}
}
