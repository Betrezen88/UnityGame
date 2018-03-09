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
		foreach (StatsEnums.Skill skill in System.Enum.GetValues(typeof(StatsEnums.Skill))) {
			skills.Add (skill, builder.Build(skill));
		}
	}
}
