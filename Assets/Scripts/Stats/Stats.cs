using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats {

	// Attribute list (good, normal, bad)
	private List<Attribute> attributes = new List<Attribute>();

	private Skills skills = new Skills();	// Skills list

	// Characteristic (good, bad)

	// Archetype

	public Stats() {
		attributes.Add (new Attribute(StatsEnums.Attribute.CONDITION, StatsEnums.AttrType.Good));

		UpdateSkillsFromAttribute ();
	private void UpdateSkillsFromAttribute() {
		foreach (Attribute attr in attributes)
			foreach (StatsEnums.Skill type in System.Enum.GetValues(typeof(StatsEnums.Skill)))
				skills.SkillList [type].IncreaseBy (attr.Skills.SkillList[type].Value);
	}
}
