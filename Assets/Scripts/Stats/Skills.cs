using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills {

	private Dictionary<StatsEnums.Skill, Skill> skills = new Dictionary<StatsEnums.Skill, Skill>();

	public Dictionary<StatsEnums.Skill, Skill> SkillList { get { return skills; } }

	public Skills() {
		CreateSkillList ();
	}

	private void CreateSkillList() {
		SkillBuilder builder = new SkillBuilder ();
		foreach (StatsEnums.Skill type in System.Enum.GetValues(typeof(StatsEnums.Skill))) {
			skills.Add (type, builder.Build(type));
		}
	}

	public List<Skill> GetByAttribute(StatsEnums.Attribute attribute) {
		List<Skill> list = new List<Skill> ();
		foreach (StatsEnums.Skill type in System.Enum.GetValues(typeof(StatsEnums.Skill))) {
			if (attribute == skills [type].Attribute)
				list.Add (skills[type]);
		}
		return list;
	}
}
